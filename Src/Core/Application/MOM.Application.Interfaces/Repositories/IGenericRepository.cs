using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MOM.Application.Interfaces.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        Microsoft.EntityFrameworkCore.DbSet<T> DbSet { get; }

        Task<T> GetByIdAsync(object id);
        Task<List<TResult>> GetAllAsync<TResult>(
            Expression<Func<T, bool>> predicate = null,
            Expression<Func<T, TResult>> selector = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            Func<IQueryable<TResult>, IOrderedQueryable<TResult>> orderByAfterMapping = null);
        Task<T> AddAsync(T entity);
        void Update(T entity);
        void Delete(T entity);
        Task<IEnumerable<T>> GetByIdsAsync<TKey>(IEnumerable<TKey> ids) where TKey : notnull;
        void DeleteRange(IEnumerable<T> entities);
        IQueryable<T> Where(Func<T, bool> predicate);
        Task<int> ExecuteUpdateAsync(Expression<Func<T, bool>> predicate, Expression<Func<Microsoft.EntityFrameworkCore.Query.SetPropertyCalls<T>, Microsoft.EntityFrameworkCore.Query.SetPropertyCalls<T>>> func);
    }
}
