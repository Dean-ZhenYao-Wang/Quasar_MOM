using Microsoft.EntityFrameworkCore;
using MOM.Application.DTOs.Menu.Responses;
using MOM.Application.Interfaces.Repositories;
using MOM.Domain.Permission;
using MOM.Infrastructure.Persistence.Contexts;
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
            return await GetAllAsync(m => m.Children.Count == 0, m => m.ToMenuTreeNodeResponse(null), o => o.OrderBy(m => m.Id));
        }
    }
}
