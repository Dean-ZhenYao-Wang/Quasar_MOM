using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MOM.Infrastructure.Persistence.Repositories
{
    public class GenericRepository<T>(DbContext dbContext) : IGenericRepository<T> where T : class
    {
        public DbSet<T> DbSet { get => dbContext.Set<T>(); }

        public virtual IQueryable<T> Where(Expression<Func<T, bool>> predicate)
        {
            return dbContext.Set<T>().Where(predicate);
        }

        public virtual IQueryable<T> AsNoTracking()
        {
            return dbContext.Set<T>().AsNoTracking();
        }

        public virtual async Task<T> GetByIdAsync(object id)
        {
            return await dbContext.Set<T>().FindAsync(id);
        }

        public virtual async Task<IEnumerable<T>> GetByIdsAsync<TKey>(IEnumerable<TKey> keys)
     where TKey : notnull // 约束 TKey 为非空类型
        {
            if (keys == null || !keys.Any())
                return Enumerable.Empty<T>();

            // 获取主键元数据
            var entityType = dbContext.Model.FindEntityType(typeof(T));
            var primaryKey = entityType.FindPrimaryKey();
            if (primaryKey == null || primaryKey.Properties.Count != 1)
                throw new InvalidOperationException("仅支持单一主键实体");

            var primaryKeyProperty = primaryKey.Properties[0];
            var primaryKeyType = primaryKeyProperty.ClrType;

            // 验证主键类型是否匹配
            if (primaryKeyType != typeof(TKey))
                throw new ArgumentException($"主键类型不匹配。预期类型: {primaryKeyType}, 实际类型: {typeof(TKey)}");

            // 直接构建表达式树 e => ids.Contains(e.Id)
            var parameter = Expression.Parameter(typeof(T), "e");
            var property = Expression.Property(parameter, primaryKeyProperty.Name);
            var containsMethod = typeof(Enumerable).GetMethods()
                .First(m => m.Name == "Contains" && m.GetParameters().Length == 2)
                .MakeGenericMethod(primaryKeyType);
            var containsCall = Expression.Call(
                null,
                containsMethod,
                Expression.Constant(keys),
                property
            );
            var lambda = Expression.Lambda<Func<T, bool>>(containsCall, parameter);

            return await dbContext.Set<T>()
                .Where(lambda)
                .ToListAsync();
        }

        public async Task<int> ExecuteUpdateAsync(Expression<Func<T, bool>> predicate, Expression<Func<SetPropertyCalls<T>, SetPropertyCalls<T>>> func)
        {
            return await dbContext.Set<T>().Where(predicate).ExecuteUpdateAsync(func);
        }

        public virtual async Task AddAsync(T entity)
        {
            await dbContext.Set<T>().AddAsync(entity);
        }

        public virtual async Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entitys)
        {
            await dbContext.Set<T>().AddRangeAsync(entitys);
            return entitys;
        }

        public void Update(T entity)
        {
            dbContext.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(T entity)
        {
            dbContext.Set<T>().Remove(entity);
        }

        public void DeleteRange(IEnumerable<T> entities)
        {
            dbContext.Set<T>().RemoveRange(entities);
        }
        public async Task DeleteRangeAsync<TKey>(IEnumerable<TKey> keys)
        {
            dbContext.Set<T>().RemoveRange(await GetByIdsAsync(keys));
        }

        public async Task<PagedResponse<TEntity>> PagedAsync<TEntity>(IQueryable<TEntity> query, int pageNumber, int pageSize) where TEntity : class
        {
            var count = await query.CountAsync();

            List<TEntity> pagedResult = null;
            if (pageSize > 0)
            {
                pagedResult = await query
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .AsNoTracking()
                .ToListAsync();
            }
            else
            {
                pagedResult = await query
                .AsNoTracking()
                .ToListAsync();
            }

            return PagedResponse<TEntity>.Ok(new PaginationResponseDto<TEntity>(pagedResult, count, pageNumber, pageSize));
        }

        public IIncludableQueryable<T, TProperty> Include<TProperty>(Expression<Func<T, TProperty>> path)
        {
            return dbContext.Set<T>().Include(path);
        }

        public async Task<int> SaveChangesAsync()
        {
            return await dbContext.SaveChangesAsync();
        }
    }
}