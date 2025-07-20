using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace MOM.Application.Infrastructure
{
    public interface IUnitOfWork : IDisposable
    {
        DbContext DbContext { get;  }

        Task<IDbContextTransaction> BeginTransactionAsync();

        Task CommitAsync();

        Task RollbackAsync();
    }
}