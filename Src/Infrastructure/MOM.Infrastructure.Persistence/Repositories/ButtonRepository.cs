using Azure.Core;
using Microsoft.EntityFrameworkCore;
using MOM.Application.Interfaces;
using MOM.Application.Interfaces.Repositories;
using MOM.Domain.Permission;
using MOM.Infrastructure.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOM.Infrastructure.Persistence.Repositories
{
    public class ButtonRepository(ApplicationDbContext dbContext) : GenericRepository<Button>(dbContext), IButtonRepository
    {
        private DbSet<Menu> Menus = dbContext.Menus;
        public async Task DeleteAsync(Guid[] dtIds)
        {
            using var transaction = await dbContext.Database.BeginTransactionAsync();
            try
            {
                await this.ExecuteUpdateAsync(m => dtIds.Contains(m.DtId), m => m.SetProperty(p => p.IsDelete, true));
                await transaction.CommitAsync();
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                throw new ApplicationException(ex.Message, ex.InnerException);
            }
        }

        public Task<List<Button>> GetButtonsByMenuIdAsync(Guid menuDtId)
        {
            return Where(m => m.MenuDtId == menuDtId).OrderBy(m => m.Id).Select(m => m).AsQueryable().ToListAsync();
        }
        public override Task<Button> AddAsync(Button entity)
        {
            if (this.Where(m => m.Id.Equals(entity.Id)).Any()|| Menus.Where(m => m.Id.Equals(entity.Id)).Any())
                throw new ApplicationException("按钮编号必须唯一");
            return base.AddAsync(entity);
        }
    }
}
