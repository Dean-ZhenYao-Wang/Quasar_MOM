using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using MOM.Application.Infrastructure.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Application.Infrastructure.Middlewares
{
    public class TransactionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IServiceProvider _serviceProvider;

        public TransactionMiddleware(RequestDelegate next, IServiceProvider serviceProvider)
        {
            _next = next;
            _serviceProvider = serviceProvider;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var endpoint = context.GetEndpoint();
            if (endpoint != null)
            {
                var actionMethod = endpoint.Metadata.GetMetadata<MethodInfo>();
                if (actionMethod != null && actionMethod.GetCustomAttribute<TransactionalAttribute>() != null)
                {
                    using (var scope = _serviceProvider.CreateScope())
                    {
                        var unitOfWork = scope.ServiceProvider.GetRequiredService<IUnitOfWork>();
                        await unitOfWork.BeginTransactionAsync();

                        try
                        {
                            await _next(context);
                            await unitOfWork.DbContext.SaveChangesAsync();
                            await unitOfWork.CommitAsync();
                        }
                        catch
                        {
                            await unitOfWork.RollbackAsync();
                            throw;
                        }
                    }
                }
                else
                {
                    await _next(context);
                }
            }
            else
            {
                await _next(context);
            }
        }
    }

}
