using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.OpenApi;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Scalar.AspNetCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MOM.Application.Infrastructure.Extensions
{
    public static class ScalarExtensions
    {
        public static IApplicationBuilder UseScalarWithVersioning(this WebApplication app)
        {
            if (app.Environment.IsDevelopment())
            {
                app.MapScalarApiReference(); // scalar/v1
                app.MapOpenApi();
            }

            return app;
        }

        public static IServiceCollection AddScalarWithVersioning(this IServiceCollection services)
        {
            services.AddOpenApi(opt =>
            {
                opt.AddDocumentTransformer<BearerSecuritySchemeTransformer>();
            });
            return services;
        }
    }
    public sealed class BearerSecuritySchemeTransformer(IAuthenticationSchemeProvider authenticationSchemeProvider) : IOpenApiDocumentTransformer
    {
        public async Task TransformAsync(OpenApiDocument document, OpenApiDocumentTransformerContext context, CancellationToken cancellationToken)
        {
            var authenticationSchemes = await authenticationSchemeProvider.GetAllSchemesAsync();
            if (authenticationSchemes.Any(authScheme => authScheme.Name == "Bearer"))
            {
                // Add the security scheme at the document level
                var requirements = new Dictionary<string,
                  OpenApiSecurityScheme>
                {
                    ["Bearer"] = new OpenApiSecurityScheme
                    {
                        Type = SecuritySchemeType.Http,
                        Scheme = "bearer", // "bearer" refers to the header name here
                        In = ParameterLocation.Header,
                        BearerFormat = "Json Web Token"
                    }
                };
                document.Components ??= new OpenApiComponents();
                document.Components.SecuritySchemes = requirements;

                // Apply it as a requirement for all operations
                foreach (var operation in document.Paths.Values.SelectMany(path => path.Operations))
                {
                    operation.Value.Security.Add(new OpenApiSecurityRequirement
                    {
                        [new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Id = "Bearer",
                                Type = ReferenceType.SecurityScheme
                            }
                        }] = Array.Empty<string>()
                    });
                }
            }
        }
    }
}