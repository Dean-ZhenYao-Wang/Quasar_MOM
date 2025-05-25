using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using MOM.Application.DTOs.HierarchyScope.Responses;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;
using MOM.Domain.isa95.CommonObjectModels;
using MOM.Infrastructure.Persistence.Contexts;
using System;
using System.Linq;
using System.Threading.Tasks;
using MOM.Application.DTOs.HierarchyScope;
namespace MOM.Infrastructure.Persistence.Repositories
{
    public class HierarchyScopeRepository(ApplicationDbContext dbContext) : GenericRepository<HierarchyScope>(dbContext), IHierarchyScopeRepository
    {
        public async Task DeleteAsync(Guid[] dtIds)
        {
            await this.ExecuteUpdateAsync(m => dtIds.Contains(m.DtId), setters => setters.SetProperty(pc => pc.IsDelete, true));
        }
        public async Task<PagedResponse<OrgResponse>> GetOrgListAsync(Guid? sourceDtId, string id, string name, int page, int pageSize)
        {
            var query = this.DbSet
                    .AsNoTracking()
                    .Include(s => s.Responsible)
                    .Where(m => sourceDtId != null ? m.SourceDtId == sourceDtId : true)
                    .Where(m => !string.IsNullOrWhiteSpace(id) ? m.Id.Contains(id) : true)
                    .Where(m => !string.IsNullOrWhiteSpace(name) ? m.Name.Contains(name) : true)
                    .GroupJoin(this.DbSet, l => l.SourceDtId, r => r.DtId, (l, r) => new { l, r })
                    .SelectMany(lr => lr.r.DefaultIfEmpty(), (lr, r) => new
                    {
                        lr.l,
                        r.Name
                    })
                    .OrderBy(lr => lr.l.Id)
                    .Select(lr => lr.l.ToOrgItemResponse(lr.l.SourceDtId, lr.l.ResponsibleName, lr.Name));

            return await PagedAsync(query, page, pageSize);
        }
    }
}