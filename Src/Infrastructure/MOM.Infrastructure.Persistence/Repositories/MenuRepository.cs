using Microsoft.EntityFrameworkCore;
using MOM.Application.DTOs.Menu.Responses;
using MOM.Application.Interfaces.Repositories;
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
        private readonly DbSet<Menu> menus = dbContext.Set<Menu>();
        private readonly DbSet<Button> buttons = dbContext.Set<Button>();

        public async Task<List<MenuTreeNodeResponse>> GetMenuTreeAsync()
        {
            var menuList = await menus.Select(m => m.ToMenuTreeNodeResponse(m.ParentMenuDtId)).ToListAsync();
            return BuildMenuTree(menuList);
        }
        // 递归构建菜单树
        List<MenuTreeNodeResponse> BuildMenuTree(IEnumerable<MenuTreeNodeResponse> menus, Guid? parentId = null)
        {
            return menus
                .Where(m => m.ParentMenuDtId == parentId)
                .Select(m =>
                {
                    m.Children = BuildMenuTree(menus, m.DtId);
                    return m;
                })
                .ToList();
        }
    }
}
