using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using MOM.Application.Interfaces;
using System.Threading.Tasks;

namespace MOM.Infrastructure.Persistence.Contexts
{
    public class UnitOfWork(ApplicationDbContext dbContext) : IUnitOfWork
    {
        public DbContext Relationships { get; set; }= dbContext;
        public async Task<bool> SaveChangesAsync()
        {
            return await dbContext.SaveChangesAsync() > 0;
        }
        public bool SaveChanges()
        {
            return dbContext.SaveChanges() > 0;
        }
        public async Task<IDbContextTransaction> BeginTransactionAsync()
        {
            return await dbContext.Database.BeginTransactionAsync();
        }

        public async Task CommitAsync(IDbContextTransaction transaction)
        {
            try
            {
                await dbContext.SaveChangesAsync();
                await transaction.CommitAsync();
            }
            finally
            {
                await transaction.DisposeAsync();
            }
        }

        public async Task RollbackAsync(IDbContextTransaction transaction)
        {
            try
            {
                await transaction.RollbackAsync();
            }
            finally
            {
                await transaction.DisposeAsync();
            }
        }
    }
}
