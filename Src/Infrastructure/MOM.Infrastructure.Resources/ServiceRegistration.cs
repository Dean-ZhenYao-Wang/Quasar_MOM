using Microsoft.Extensions.DependencyInjection;
using MOM.Application.Wrappers;
using MOM.Infrastructure.Resources.Services;

namespace MOM.Infrastructure.Resources
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddResourcesInfrastructure(this IServiceCollection services)
        {
            services.AddSingleton<ITranslator, Translator>();

            return services;
        }
    }
}