using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Query;
using MOM.Application.Infrastructure.Services;
using MOM.Domain.Common;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace MOM.Infrastructure.Persistence.Extensions
{
    public static class EntityFrameworkExtensions
    {
        /// <summary>
        /// Applies auditing information to entities that implement AuditableBaseEntity.
        /// </summary>
        /// <param name="changeTracker">The ChangeTracker instance to track entity changes.</param>
        /// <param name="authenticatedUser">The authenticated user service to get user information.</param>
        public static void ApplyAuditing(this ChangeTracker changeTracker, IAuthenticatedUserService authenticatedUser)
        {
            var userId = string.IsNullOrEmpty(authenticatedUser.DtId)
                ? Guid.Empty
                : Guid.Parse(authenticatedUser.DtId);

            var currentTime = DateTime.UtcNow;

            foreach (var entry in changeTracker.Entries())
            {
                var entityType = entry.Entity.GetType();

                if (typeof(BaseEntity).IsAssignableFrom(entityType) ||
                    (entityType.BaseType?.IsGenericType ?? false) &&
                    entityType.BaseType.GetGenericTypeDefinition() == typeof(BaseEntity))
                {
                    dynamic auditableEntity = entry.Entity;

                    if (entry.State == EntityState.Added)
                    {
                        auditableEntity.Created = currentTime;
                        auditableEntity.CreatedBy = userId;
                    }
                    else if (entry.State == EntityState.Modified)
                    {
                        auditableEntity.LastModified = currentTime;
                        auditableEntity.LastModifiedBy = userId;
                    }
                }
            }
        }

        /// <summary>
        /// Configures decimal properties for the given DbContext to have a specific precision and scale.
        /// </summary>
        /// <param name="context">The DbContext to apply configurations to.</param>
        /// <param name="builder">The ModelBuilder to configure entity properties.</param>
        public static void ConfigureDecimalProperties(this DbContext context, ModelBuilder builder)
        {
            foreach (var property in builder.Model.GetEntityTypes()
                         .SelectMany(t => t.GetProperties())
                         .Where(p => p.ClrType == typeof(decimal) || p.ClrType == typeof(decimal?)))
            {
                property.SetColumnType("decimal(18,6)");
            }
            // 应用全局过滤条件
            builder.Entity<BaseEntity>().HasQueryFilter(e => !e.IsDelete);

            builder.ApplyConfigurationsFromAssembly(context.GetType().Assembly);
        }

        private static LambdaExpression ConvertExpression<TInterface>(Expression<Func<TInterface, bool>> expression, Type entityType)
        {
            var parameter = Expression.Parameter(entityType);
            var body = ReplacingExpressionVisitor.Replace(expression.Parameters.Single(), parameter, expression.Body);
            return Expression.Lambda(body, parameter);
        }
    }
}