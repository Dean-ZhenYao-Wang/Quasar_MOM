using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MOM.Application;
using MOM.Application.Interfaces;
using MOM.Infrastructure.FileManager;
using MOM.Infrastructure.FileManager.Contexts;
using MOM.Infrastructure.Hangfire;
using MOM.Infrastructure.Identity;
using MOM.Infrastructure.Identity.Contexts;
using MOM.Infrastructure.Identity.Models;
using MOM.Infrastructure.Identity.Seeds;
using MOM.Infrastructure.Persistence;
using MOM.Infrastructure.Persistence.Contexts;
using MOM.Infrastructure.Persistence.Seeds;
using MOM.Infrastructure.Resources;
using MOM.WebApi.Infrastructure.Extensions;
using MOM.WebApi.Infrastructure.Middlewares;
using MOM.WebApi.Infrastructure.Services;
using Scalar.AspNetCore;
using Serilog;
using System;
using System.Net.Http;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpContextAccessor();

bool useInMemoryDatabase = builder.Configuration.GetValue<bool>("UseInMemoryDatabase");
builder.Services.AddPersistenceInfrastructure(builder.Configuration, useInMemoryDatabase);
builder.Services.AddFileManagerInfrastructure(builder.Configuration, useInMemoryDatabase);
builder.Services.AddIdentityInfrastructure(builder.Configuration, useInMemoryDatabase);
builder.Services.AddResourcesInfrastructure();
builder.Services.AddHangfireInfrastructure(builder.Configuration);
builder.Services.AddScoped<IAuthenticatedUserService, AuthenticatedUserService>();
builder.Services.AddControllers();
builder.Services.AddVersioning();
builder.Services.AddFluentValidationAutoValidation();
builder.Services.AddScalarWithVersioning();
builder.Services.AddAnyCors();
builder.Services.AddCustomLocalization(builder.Configuration);
builder.Services.AddHealthChecks();
builder.Services.AddOrchardCore().AddMvc();
builder.Host.UseSerilog((context, configuration) => configuration.ReadFrom.Configuration(context.Configuration));


var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    if (!useInMemoryDatabase)
    {
        await services.GetRequiredService<IdentityContext>().Database.MigrateAsync();
        await services.GetRequiredService<ApplicationDbContext>().Database.MigrateAsync();
        await services.GetRequiredService<FileManagerDbContext>().Database.MigrateAsync();
    }

    //Seed Data
    await DefaultRoles.SeedAsync(services.GetRequiredService<RoleManager<ApplicationRole>>());
    await DefaultBasicUser.SeedAsync(services.GetRequiredService<UserManager<ApplicationUser>>());
    await DefaultData.SeedAsync(services.GetRequiredService<ApplicationDbContext>());
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


app.Run();

public partial class Program
{
}
