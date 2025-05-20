using Hangfire;
using Hangfire.Dashboard.BasicAuthorization;
using Hangfire.HttpJob;
using Hangfire.SqlServer;
using Hangfire.Tags.SqlServer;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MOM.Infrastructure.Hangfire
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddHangfireInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddHangfire(configura =>
            {
                //指定存储介质

                #region SqlServer

                configura.UseSqlServerStorage(
                   configuration.GetConnectionString("HangfireConnection"),
                       new SqlServerStorageOptions()
                       {
                           CommandBatchMaxTimeout = TimeSpan.FromMinutes(5),
                           SlidingInvisibilityTimeout = TimeSpan.FromMinutes(5),
                           QueuePollInterval = TimeSpan.Zero,
                           UseRecommendedIsolationLevel = true,
                           DisableGlobalLocks = true
                       })

                #endregion SqlServer

                .UseTagsWithSql()//nuget引入Hangfire.Tags.SqlServer
                .UseHangfireHttpJob();
            });
            services.AddHangfireServer();
            return services;
        }

        public static IApplicationBuilder UseHangfire(this IApplicationBuilder app)
        {
            app.UseHangfireDashboard("/hangfire", new DashboardOptions()
            {
                Authorization = [
                                  new BasicAuthAuthorizationFilter(new BasicAuthAuthorizationFilterOptions(){
                           SslRedirect=false,
                            RequireSsl=false,
                             Users=[
                                  new BasicAuthAuthorizationUser(){
                                      Login="admin",
                                      PasswordClear="test"
                                  }
                             ]
                      })
                            ]
            });//支持可视化界面 ---任何一个用户都能够来访问；所以需要加一道屏障

            return app;
        }
    }
}