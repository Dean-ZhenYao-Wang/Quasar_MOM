using Microsoft.EntityFrameworkCore;
using MOM.Application.Interfaces.Repositories;
using MOM.Domain.isa95.CommonObjectModels;
using MOM.Infrastructure.Persistence.Contexts;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace MOM.Infrastructure.Persistence.Repositories
{
    public class HierarchyScopeRepository(ApplicationDbContext dbContext) : GenericRepository<HierarchyScope>(dbContext), IHierarchyScopeRepository
    {
        public async Task DeleteAsync(Guid[] dtIds)
        {
            await this.ExecuteUpdateAsync(m => dtIds.Contains(m.DtId), setters => setters.SetProperty(pc => pc.IsDelete, true));
        }
    }
}