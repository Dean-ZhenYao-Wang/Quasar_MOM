using Azure.Core;
using MediatR;
using Microsoft.EntityFrameworkCore;
using MOM.Application.DTOs.Menu;
using MOM.Application.DTOs.Menu.Responses;
using MOM.Application.Infrastructure.Services;
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
    public class MenuRepository(ApplicationDbContext dbContext, IAuthenticatedUserService currentUser) : GenericRepository<Menu>(dbContext), IMenuRepository
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
            var allMenus_Query = DbSet.AsNoTracking();
            if (!currentUser.Roles.Contains("*:*:*"))
            {
                allMenus_Query = allMenus_Query.Where(m => currentUser.Roles.Contains(m.Id));
            }
            var allMenus = await allMenus_Query.OrderBy(m => m.Id).ToListAsync();
            var menuList = BuildTree(allMenus);
            return menuList;
        }
        private List<MenuTreeNodeResponse> BuildTree(List<Menu> menus)
        {
            var rootMenus = menus.Where(m => m.ParentMenuDtId == null).Select(m => m.ToMenuTreeNodeResponse()).ToList();
            foreach (var menu in rootMenus)
            {
                menu.Children = GetChildren(menu, menus);
            }
            return rootMenus;
        }

        private List<MenuTreeNodeResponse> GetChildren(MenuTreeNodeResponse parent, List<Menu> allMenus)
        {
            var children = allMenus.Where(m => m.ParentMenuDtId == parent.DtId).Select(m => m.ToMenuTreeNodeResponse()).ToList();
            foreach (var child in children)
            {
                child.Children = GetChildren(child, allMenus);
            }
            return children;
        }
        public override Task<Menu> AddAsync(Menu entity)
        {
            if (buttons.Where(m => m.Id.Equals(entity.Id)).Any() || this.Where(m => m.DtId != entity.DtId && m.Id.Equals(entity.Id)).Any())
                throw new ApplicationException("菜单编号必须唯一");
            return base.AddAsync(entity);
        }
    }
}
