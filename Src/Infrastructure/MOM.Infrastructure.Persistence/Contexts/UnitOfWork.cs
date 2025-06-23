using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using MOM.Application.Interfaces;
using System.Threading.Tasks;

namespace MOM.Infrastructure.Persistence.Contexts
{
    public class UnitOfWork(ApplicationDbContext dbContext) : IUnitOfWork
    {
        public DbContext DbContext { get; set; } = dbContext;
        private IDbContextTransaction tran;

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
            tran = await dbContext.Database.BeginTransactionAsync();
            return tran;
        }

        public async Task CommitAsync()
        {
            try
            {
                await dbContext.SaveChangesAsync();
                await tran.CommitAsync();
            }
            finally
            {
                await tran.DisposeAsync();
            }
        }

        public async Task RollbackAsync()
        {
            try
            {
                await tran.RollbackAsync();
            }
            finally
            {
                await tran.DisposeAsync();
            }
        }
    }
}