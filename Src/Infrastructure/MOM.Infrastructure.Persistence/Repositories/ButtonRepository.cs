using Microsoft.EntityFrameworkCore;
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
        public async Task DeleteAsync(Guid[] dtIds)
        {
            await this.ExecuteUpdateAsync(m => dtIds.Contains(m.DtId), m => m.SetProperty(p => p.IsDelete, true));
        }

        public Task<List<Button>> GetButtonsByMenuIdAsync(Guid menuDtId)
        {
            return Where(m => m.MenuDtId == menuDtId).OrderBy(m => m.Id).Select(m => m).AsQueryable().ToListAsync();
        }

        public override Task<Button> AddAsync(Button entity)
        {
            return base.AddAsync(entity);
        }
    }
}