using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace MOM.Application.Interfaces
{
    public interface IUnitOfWork
    {
        DbContext DbContext { get; set; }

        Task<bool> SaveChangesAsync();

        Task<IDbContextTransaction> BeginTransactionAsync();

        Task CommitAsync();

        Task RollbackAsync();
    }
}