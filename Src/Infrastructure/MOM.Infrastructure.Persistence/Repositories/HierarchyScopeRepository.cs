using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using MOM.Application.DTOs.HierarchyScope;
using MOM.Application.DTOs.HierarchyScope.Responses;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;
using MOM.Domain.Common.EnumType;
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
            return await this._dbContext.Enterprise.Where(m => m.DtId == dtId).SingleOrDefaultAsync();
        }
        public async Task<Area> GetAreaByKeyAsync(Guid dtId)
        {
            return await this._dbContext.Area.Where(m => m.DtId == dtId).SingleOrDefaultAsync();
        }
        public async Task<EntityEntry<Enterprise>> AddEnterpriseAsync(Enterprise enterprise)
        {
            var model = await this._dbContext.Enterprise.AddAsync(enterprise);
            return model;
        }
        public async Task<EntityEntry<Area>> AddDepartmentAsync(Area area)
        {
            var model = await this._dbContext.Area.AddAsync(area);
            return model;
        }

        public async Task DeleteAsync(Guid[] dtIds)
        {
            await this.ExecuteUpdateAsync(m => dtIds.Contains(m.DtId), setters => setters.SetProperty(pc => pc.IsDelete, true));
        }

        public async Task<PagedResponse<OrgResponse>> GetEnterpriseListAsync(string id, string name, int page, int pageSize)
        {
            var query = this._dbContext.Enterprise
                .Include(t => t.Responsible)
                .Include(e => e.Source)
                .Where(m => !string.IsNullOrWhiteSpace(id) ? m.Id.Contains(id) : true)
                .Where(m => !string.IsNullOrWhiteSpace(name) ? m.Name.Contains(name) : true)
                .Select(m => m.ToOrgItemResponse(m.SourceDtId, m.ResponsibleName, m.Source.Name));

            return await this.PagedAsync(query, page, pageSize);
        }

        public async Task<PagedResponse<OrgResponse>> GetAreaListAsync(Guid sourceDtId, string? id, string? name, int page, int pageSize)
        {
            var query = this._dbContext.Area
                .Include(m => m.Responsible)
                .Include(m => m.Source)
                .Where(m => m.SourceDtId == sourceDtId)
                .Where(m => !string.IsNullOrWhiteSpace(id) ? m.Id.Contains(id) : true)
                .Where(m => !string.IsNullOrWhiteSpace(name) ? m.Name.Contains(name) : true)
                .Select(m => m.ToOrgItemResponse(m.SourceDtId, m.ResponsibleName, m.Source.Name));

            return await this.PagedAsync(query, page, pageSize);
        }
        public async Task<PagedResponse<OrgResponse>> GetDepartmentListAsync(Guid? sourceDtId, string? id, string? name, int page, int pageSize)
        {
            var query = this._dbContext.Area
                .Include(m => m.Responsible)
                .Include(m => m.Source)
                .Where(m => m.Source is Enterprise || m.Source.Contains.Any(c => c.TargetId == m.DtId && c.Name.Equals("部门")))
                .Where(m => sourceDtId.HasValue ? m.SourceDtId == sourceDtId.Value : true)
                .Where(m => !string.IsNullOrWhiteSpace(id) ? m.Id.Contains(id) : true)
                .Where(m => !string.IsNullOrWhiteSpace(name) ? m.Name.Contains(name) : true)
                .Select(m => m.ToOrgItemResponse(m.SourceDtId, m.ResponsibleName, m.Source.Name));

            return await this.PagedAsync(query, page, pageSize);
        }

        public async Task<PagedResponse<OrgResponse>> GetFactoryListAsync(string id, string name, int page, int pageSize)
        {
            var query = this._dbContext.Site
                .Include(t => t.Responsible)
                .Include(t => t.Source)
                .Where(m => m.EquipmentLevel == HierarchyScopeEquipmentLevel.Site)
                .Where(m => !string.IsNullOrWhiteSpace(id) ? m.Id.Contains(id) : true)
                .Where(m => !string.IsNullOrWhiteSpace(name) ? m.Name.Contains(name) : true)
                .Select(m => new OrgResponse
                {
                    Active = m.Active,
                    Address = m.Address,
                    Description = m.Description,
                    SourceName = m.Source.Name,
                    SourceDtId = m.SourceDtId,
                    DtId = m.DtId,
                    EquipmentLevel = m.EquipmentLevel,
                    FullPath = m.FullPath,
                    Id = m.Id,
                    Name = m.Name,
                    ResponsibleDtId = m.ResponsibleDtId,
                    ResponsibleName = m.ResponsibleName,
                });
            return await this.PagedAsync(query, page, pageSize);
        }

        public async Task<EntityEntry<Site>> AddFactoryAsync(Site site)
        {
            var model = await this._dbContext.Site.AddAsync(site);
            return model;
        }

        public async Task<Site> GetSiteByKeyAsync(Guid dtId)
        {
            return await this._dbContext.Site.Where(m=>m.DtId == dtId).SingleOrDefaultAsync();
        }
    }
}