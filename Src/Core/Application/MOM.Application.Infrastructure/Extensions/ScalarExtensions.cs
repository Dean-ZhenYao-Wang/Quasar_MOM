using Asp.Versioning.ApiExplorer;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.AspNetCore.OpenApi;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Scalar.AspNetCore;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MOM.Application.Infrastructure.Extensions
{
    public static class ScalarExtensions
    {
        static string[] versions = ["v1", "v2"];
        public static IApplicationBuilder UseScalarWithVersioning(this WebApplication app)
        {
            // 获取API版本描述提供者
            var apiVersionDescriptionProvider = app.Services.GetRequiredService<IApiVersionDescriptionProvider>();
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger(options =>
                {
                    options.RouteTemplate = "/openapi/{documentName}.json";
                });
                app.UseSwaggerUI(options =>
                {
                    // 为每个API版本添加Swagger端点
                    foreach (var description in apiVersionDescriptionProvider.ApiVersionDescriptions)
                    {
                        options.SwaggerEndpoint(
                              $"/openapi/{description.GroupName}.json",
                              $"MOM API {description.GroupName}"
                        );
                    }
                });
                app.MapScalarApiReference(options =>
                {
                    options.AddDocuments(versions);
                });
            }

            return app;
        }

        public static IServiceCollection AddScalarWithVersioning(this IServiceCollection services)
        {
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            // 注册配置Swagger选项的服务
            services.AddTransient<IConfigureOptions<SwaggerGenOptions>, ConfigureSwaggerOptions>();
            services.AddSwaggerGen(setup =>
            {
                setup.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Name = "Authorization",                    // HTTP 头的名称
                    In = ParameterLocation.Header,             // Token 位置（Header）
                    Type = SecuritySchemeType.Http,            // 类型改为 Http（关键点）
                    Scheme = "Bearer",                         // 认证方案名称
                    BearerFormat = "JWT",                      // Token 格式描述
                    Description = "JWT 令牌，直接粘贴 Token 即可（无需输入 'Bearer ' 前缀）。示例：eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9..."
                });

                setup.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"                  // 引用上述定义
                            }
                        },
                        Array.Empty<string>()                  // 作用域（若无，留空）
                    }
                });
                // 加载主项目的 XML 注释
                string basePath = Path.GetDirectoryName(AppContext.BaseDirectory);//获取应用程序所在目录（绝对，不受工作目录影响，建议采用此方法获取路径）

                IEnumerable<string> files = Directory.GetFiles(basePath).Where(m => m.Contains(".xml"));
                foreach (var file in files)
                {
                    setup.IncludeXmlComments(file, true);
                }

            });
            return services;
        }
    }
    public class ConfigureSwaggerOptions : IConfigureOptions<SwaggerGenOptions>
    {
        private readonly IApiVersionDescriptionProvider _provider;

        public ConfigureSwaggerOptions(IApiVersionDescriptionProvider provider)
        {
            _provider = provider;
        }

        public void Configure(SwaggerGenOptions options)
        {
            foreach (var description in _provider.ApiVersionDescriptions)
            {
                options.SwaggerDoc(description.GroupName, CreateInfoForApiVersion(description));
            }
        }

        private static OpenApiInfo CreateInfoForApiVersion(ApiVersionDescription description)
        {
            var info = new OpenApiInfo
            {
                Title = "MOM API",
                Version = "v" + description.ApiVersion.ToString()
            };

            if (description.IsDeprecated)
            {
                info.Description += " 此API版本已弃用。";
            }

            return info;
        }
    }
}