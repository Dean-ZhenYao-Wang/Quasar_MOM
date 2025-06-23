using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace MOM.Application.Interfaces.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        Microsoft.EntityFrameworkCore.DbSet<T> DbSet { get; }
        DbContext DbContext { get; }

        Task<T> GetByIdAsync(object id);

        Task AddAsync(T entity);

        void Update(T entity);

        void Delete(T entity);

        Task<IEnumerable<T>> GetByIdsAsync<TKey>(IEnumerable<TKey> ids) where TKey : notnull;

        void DeleteRange(IEnumerable<T> entities);

        IQueryable<T> Where(Expression<Func<T, bool>> predicate);

        Task<int> ExecuteUpdateAsync(Expression<Func<T, bool>> predicate, Expression<Func<Microsoft.EntityFrameworkCore.Query.SetPropertyCalls<T>, Microsoft.EntityFrameworkCore.Query.SetPropertyCalls<T>>> func);

        Task<Wrappers.PagedResponse<TEntity>> PagedAsync<TEntity>(IQueryable<TEntity> query, int pageNumber, int pageSize) where TEntity : class;

        IIncludableQueryable<T, TProperty> Include<TProperty>(Expression<Func<T, TProperty>> path);

        IQueryable<T> AsNoTracking();

        Task<int> SaveChangesAsync();
    }
}