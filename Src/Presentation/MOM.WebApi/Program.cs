using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using MOM.Application.Infrastructure.Extensions;
using MOM.Application.Infrastructure.Middlewares;
using MOM.Application.Infrastructure.Services;
using MOM.Application.Infrastructure.Settings;
using MOM.Application.Wrappers;
using MOM.Infrastructure.FileManager;
using MOM.Infrastructure.FileManager.Contexts;
using MOM.Infrastructure.Hangfire;
using MOM.Infrastructure.Persistence;
using MOM.Infrastructure.Persistence.Contexts;
using MOM.Infrastructure.Persistence.Seeds;
using MOM.Infrastructure.Resources;
using Serilog;
using System;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Text;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpContextAccessor();

var enterpriseSettings = builder.Configuration.GetSection(nameof(EnterpriseSettings)).Get<EnterpriseSettings>();
builder.Services.AddSingleton(enterpriseSettings);

bool useInMemoryDatabase = builder.Configuration.GetValue<bool>("UseInMemoryDatabase");
builder.Services.AddPersistenceInfrastructure(builder.Configuration, useInMemoryDatabase);
builder.Services.AddFileManagerInfrastructure(builder.Configuration, useInMemoryDatabase);

var jwtSettings = builder.Configuration.GetSection(nameof(JwtSettings)).Get<JwtSettings>();
builder.Services.AddSingleton(jwtSettings);

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(o =>
{
    o.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,//是否验证签名,不验证的话可以篡改数据，不安全
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings.Key)),//解密的密钥
        ValidateIssuer = true,//是否验证发行人，就是验证载荷中的Iss是否对应ValidIssuer参数
        ValidIssuer = jwtSettings.Issuer,//发行人
        ValidateAudience = true,//是否验证订阅人，就是验证载荷中的Aud是否对应ValidAudience参数
        ValidAudience = jwtSettings.Audience,//订阅人
        ValidateLifetime = true,//是否验证过期时间，过期了就拒绝访问
        ClockSkew = TimeSpan.Zero,//这个是缓冲过期时间，也就是说，即使我们配置了过期时间，这里也要考虑进去，过期时间+缓冲，默认好像是7分钟，你可以直接设置为0
    };

    o.RequireHttpsMetadata = false;
    o.SaveToken = false;

    o.Events = new JwtBearerEvents()
    {
        OnChallenge = async context =>
        {
            context.HandleResponse();
            context.Response.StatusCode = 401;
            await context.Response.WriteAsJsonAsync(BaseResult.Failure(new Error(ErrorCode.AccessDenied, "You are not Authorized")));
        },
        OnForbidden = async context =>
        {
            context.Response.StatusCode = 403;
            await context.Response.WriteAsJsonAsync(BaseResult.Failure(new Error(ErrorCode.AccessDenied, "You are not authorized to access this resource")));
        },
        OnTokenValidated = async context =>
        {
            // 1. 基础声明验证
            var claimsIdentity = context.Principal?.Identity as ClaimsIdentity;
            if (claimsIdentity?.Claims.Any() != true)
            {
                context.Fail("This token has no claims.");
                return;
            }

            // 2. 获取用户ID声明
            var userIdClaim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            if (userIdClaim == null || !Guid.TryParse(userIdClaim.Value, out var userId))
            {
                context.Fail("Invalid user identifier");
                return;
            }

            // 3. 从数据库验证用户状态
            var dbContext = context.HttpContext.RequestServices.GetRequiredService<ApplicationDbContext>();
            var user = await dbContext.Person.FindAsync(userId);

            if (user == null)
            {
                context.Fail("User not found");
                return;
            }

            // 4. 验证安全戳（替代SignInManager的验证）
            var tokenSecurityStamp = claimsIdentity.FindFirst("SecurityStamp")?.Value;
            if (string.IsNullOrEmpty(tokenSecurityStamp) || tokenSecurityStamp != user.SecurityStamp)
            {
                context.Fail("Token security stamp is not valid");
                return;
            }

            // 5. 可选：检查用户是否被锁定
            if (user.LockoutOnFailure)
            {
                context.Fail("User account is locked");
                return;
            }
        }
    };
});

builder.Services.AddResourcesInfrastructure();
builder.Services.AddHangfireInfrastructure(builder.Configuration);

builder.Services.AddTransient<IAuthenticatedUserService>(serviceProvider =>
{
    var httpContextAccessor = serviceProvider.GetRequiredService<IHttpContextAccessor>();
    return new AuthenticatedUserService(httpContextAccessor);
});

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    options.JsonSerializerOptions.WriteIndented = true;
}); ;
builder.Services.AddVersioning();
builder.Services.AddFluentValidationAutoValidation();
builder.Services.AddScalarWithVersioning();
builder.Services.AddAnyCors();
builder.Services.AddCustomLocalization(builder.Configuration);
builder.Services.AddHealthChecks();
builder.Services.AddOrchardCore().AddMvc();
builder.Services.AddMediatR(cfg =>
{
    var moduleAssemblies = AppDomain.CurrentDomain.GetAssemblies()
        .Where(assembly =>
            assembly.FullName!.StartsWith("MOM.Application.Features.") && // 模块命名前缀
            !assembly.IsDynamic &&
            !assembly.FullName.Contains("Tests") // 排除测试程序集
        ).ToList();

    cfg.RegisterServicesFromAssemblies(moduleAssemblies.ToArray());
});
// 注册管道（Program.cs）
builder.Services.AddScoped(typeof(IPipelineBehavior<,>), typeof(CommandExceptionPipeline<,>));

Log.Logger = new LoggerConfiguration().ReadFrom.Configuration(builder.Configuration)
    .Enrich.FromLogContext()
    .CreateLogger();
builder.Host.UseSerilog(Log.Logger);

var app = builder.Build();
// 添加路由调试中间件
app.Use(async (context, next) =>
{
    if (context.Request.Path == "/debug-routes")
    {
        var endpointDataSource = context.RequestServices.GetRequiredService<EndpointDataSource>();
        foreach (var endpoint in endpointDataSource.Endpoints)
        {
            var routePattern = (endpoint as RouteEndpoint)?.RoutePattern?.RawText;
            var httpMethods = endpoint.Metadata.GetMetadata<HttpMethodMetadata>()?.HttpMethods;
            await context.Response.WriteAsync($"{string.Join(", ", httpMethods)}: {routePattern}\n");
        }
        return;
    }
    await next();
});
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    if (!useInMemoryDatabase)
    {
        await services.GetRequiredService<ApplicationDbContext>().Database.MigrateAsync();
        await services.GetRequiredService<FileManagerDbContext>().Database.MigrateAsync();
    }

    //Seed Data
    await DefaultData.SeedAsync(services.GetRequiredService<ApplicationDbContext>(), enterpriseSettings);
}
app.UseCustomLocalization();
app.UseAnyCors();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.UseScalarWithVersioning();
app.UseMiddleware<ErrorHandlerMiddleware>();
app.UseHangfire();
app.UseHealthChecks("/health");
app.MapControllers();
app.UseOrchardCore();
app.UseSerilogRequestLogging();

var client = new HttpClient();
client.Timeout = TimeSpan.FromSeconds(60);
#pragma warning disable CS4014 // 由于此调用不会等待，因此在调用完成前将继续执行当前方法
client.GetAsync(enterpriseSettings.Host + "/api/v1/Doc/GetErrorCodes");
#pragma warning restore CS4014 // 由于此调用不会等待，因此在调用完成前将继续执行当前方法

app.Run();