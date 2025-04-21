using Azure.Core;
using Microsoft.EntityFrameworkCore;
using MOM.Application.DTOs.Menu.Responses;
using MOM.Application.Interfaces;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;
using MOM.Domain.Permission;
using MOM.Infrastructure.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOM.Infrastructure.Persistence.Repositories
{
    public class MenuRepository(ApplicationDbContext dbContext) : GenericRepository<Menu>(dbContext), IMenuRepository
    {
        private readonly DbSet<Button> buttons = dbContext.Set<Button>();

        public async Task DeleteAsync(Guid[] dtIds)
        {
            using var transaction = await dbContext.Database.BeginTransactionAsync();
            try
            {
                await this.ExecuteUpdateAsync(m => dtIds.Contains(m.DtId), m => m.SetProperty(p => p.IsDelete, true));
                await dbContext.Buttons.Where(m => dtIds.Contains(m.MenuDtId)).ExecuteUpdateAsync(m => m.SetProperty(p => p.IsDelete, true));
                await this.ExecuteUpdateAsync(m => m.ParentMenuDtId != null && dtIds.Contains(m.ParentMenuDtId.Value), m => m.SetProperty(p => p.IsDelete, true));
                await dbContext.Buttons.Where(m => dbContext.Menus.Where(p => p.ParentMenuDtId != null && dtIds.Contains(p.ParentMenuDtId.Value)).Select(p => p.DtId)
                .Contains(m.MenuDtId)).ExecuteUpdateAsync(m => m.SetProperty(p => p.IsDelete, true));
                await transaction.CommitAsync();
            }
            catch (Exception ex)
            {
                // 回滚事务
                await transaction.RollbackAsync();
                throw new ApplicationException(ex.Message, ex.InnerException);
            }
        }

        public async Task<List<MenuTreeNodeResponse>> GetMenuTreeAsync()
        {
            var menuList = await this.DbSet.Select(m => m.ToMenuTreeNodeResponse()).ToListAsync();
            return menuList;
        }
    }
}
