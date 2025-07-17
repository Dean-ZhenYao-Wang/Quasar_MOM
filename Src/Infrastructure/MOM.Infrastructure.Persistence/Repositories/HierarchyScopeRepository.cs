using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using MOM.Application.DTOs.HierarchyScope;
using MOM.Application.DTOs.HierarchyScope.Responses;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;
using MOM.Domain.isa95.CommonObjectModels;
using MOM.Domain.isa95.EquipmentHierarchy;
using MOM.Infrastructure.Persistence.Contexts;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace MOM.Infrastructure.Persistence.Repositories
{
    public class HierarchyScopeRepository(ApplicationDbContext dbContext) : GenericRepository<HierarchyScope>(dbContext), IHierarchyScopeRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public async Task<Enterprise> GetEnterpriseByKeyAsync(Guid dtId)
        {
            return await this._dbContext.Enterprise.Where(m => m.DtId == dtId).FirstOrDefaultAsync();
        }
        public async Task<EntityEntry<TEntity>> AddAsync<TEntity>(TEntity org) where TEntity : HierarchyScope
        {
            var model= await this._dbContext.Set<TEntity>().AddAsync(org);
            await this.SaveChangesAsync();
            if (org.SourceDtId != null)
            {
                await AddParent<TEntity>(org);
            }
            return model;
        }

        private async Task AddParent<TEntity>(TEntity enterprise) where TEntity : HierarchyScope
        {
            var source = await this.GetByKeyAsync(enterprise.SourceDtId.Value);
            source.AddChild(enterprise.DtId);
            await this.SaveChangesAsync();
        }

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

        public async Task<Enterprise> GetEnterpriseWithDepartmentAsync(Guid enterpriseId)
        {
            var enterprise = await _dbContext.Enterprise
                .Include(e => e.Contains)
                .ThenInclude(c => c.Target)
                .FirstOrDefaultAsync(e => e.DtId == enterpriseId);

            return enterprise;
        }
    }
}