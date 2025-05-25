using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace MOM.Application.Interfaces
{
    public interface IUnitOfWork
    {
        DbContext Relationships { get; set; }

        Task<bool> SaveChangesAsync();

        Task<IDbContextTransaction> BeginTransactionAsync();

        Task CommitAsync();

        Task RollbackAsync();
    }
}