using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace MOM.Application.Infrastructure.Extensions
{
    public static class VersioningExtensions
    {
        public static IServiceCollection AddVersioning(this IServiceCollection services)
        {
            services.AddApiVersioning(setup =>
            {
                setup.DefaultApiVersion = new ApiVersion(1, 0);
                setup.AssumeDefaultVersionWhenUnspecified = true;
                setup.ReportApiVersions = true;
            });

            //services.AddScalarWithVersioning().AddVersionedApiExplorer(setup =>
            //{
            //    setup.GroupNameFormat = "'v'VVV";
            //    setup.SubstituteApiVersionInUrl = true;
            //});

            return services;
        }

    }
}