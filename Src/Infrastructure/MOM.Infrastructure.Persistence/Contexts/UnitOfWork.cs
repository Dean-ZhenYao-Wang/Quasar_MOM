using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using MOM.Application.Infrastructure;
using System;
using System.Threading.Tasks;

namespace MOM.Infrastructure.Persistence.Contexts
{
    public class UnitOfWork(ApplicationDbContext dbContext) : IUnitOfWork
    {
        public DbContext DbContext => dbContext;
        private IDbContextTransaction tran;
        private bool _disposed;

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
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    dbContext.Dispose();
                }
                _disposed = true;
            }
        }
    }
}