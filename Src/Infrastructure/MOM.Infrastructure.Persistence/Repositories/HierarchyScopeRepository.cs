using Microsoft.AspNetCore.Mvc.Filters;
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
        public async Task<Site> GetSiteByKeyAsync(Guid dtId)
        {
            return await this._dbContext.Site.Where(m => m.DtId == dtId).SingleOrDefaultAsync();
        }
        public async Task<Area> GetAreaByKeyAsync(Guid dtId)
        {
            return await this._dbContext.Area.Where(m => m.DtId == dtId).SingleOrDefaultAsync();
        }
        public async Task<ProductionLine> GetProductionLineByKeyAsync(Guid dtId)
        {
            return await this._dbContext.ProductionLine.Where(m => m.DtId == dtId).SingleOrDefaultAsync();
        }

        public async Task<ProductionUnit> GetProductionUnitByKeyAsync(Guid dtId)
        {
            return await this._dbContext.ProductionUnit.Where(m => m.DtId == dtId).SingleOrDefaultAsync();
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
        public async Task<EntityEntry<Site>> AddFactoryAsync(Site site)
        {
            var model = await this._dbContext.Site.AddAsync(site);
            return model;
        }
        /// <summary>
        /// 添加区域/车间
        /// </summary>
        /// <param name="area"></param>
        /// <returns></returns>
        public async Task<EntityEntry<Area>> AddAreaAsync(Area area)
        {
            var model = await this._dbContext.Area.AddAsync(area);
            return model;
        }
        public async Task<EntityEntry<ProductionLine>> AddProductionLineAsync(ProductionLine productionLine)
        {
            var model = await this._dbContext.ProductionLine.AddAsync(productionLine);
            return model;
        }

        public async Task<EntityEntry<ProductionUnit>> AddProductionUnitAsync(ProductionUnit productionUnit)
        {
            var model = await this._dbContext.ProductionUnit.AddAsync(productionUnit);
            return model;
        }

        public async Task DeleteAsync(Guid[] dtIds)
        {
            await this.ExecuteUpdateAsync(m => dtIds.Contains(m.DtId), setters => setters.SetProperty(pc => pc.IsDelete, true));
        }

        public async Task<PagedResponse<OrgResponse>> GetEnterpriseListAsync(Guid? sourceDtId, string id, string name, int page, int pageSize)
        {
            var query = this._dbContext.Enterprise
                .Include(t => t.Responsible)
                .Include(e => e.Source)
                .Where(m => sourceDtId.HasValue ? m.SourceDtId == sourceDtId.Value : true)
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
                .Where(m => sourceDtId.HasValue ? m.SourceDtId == sourceDtId.Value : m.Source is Enterprise)
                .Where(m => !string.IsNullOrWhiteSpace(id) ? m.Id.Contains(id) : true)
                .Where(m => !string.IsNullOrWhiteSpace(name) ? m.Name.Contains(name) : true)
                .Select(m => m.ToOrgItemResponse(m.SourceDtId, m.ResponsibleName, m.Source.Name));

            return await this.PagedAsync(query, page, pageSize);
        }

        public async Task<PagedResponse<OrgResponse>> GetFactoryListAsync(Guid? sourceDtId, string id, string name, int page, int pageSize)
        {
            var query = this._dbContext.Site
                .Include(t => t.Responsible)
                .Include(t => t.Source)
                .Where(m => sourceDtId.HasValue ? m.SourceDtId == sourceDtId.Value : true)
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

        public async Task<PagedResponse<OrgResponse>> GetAreaListAsync(Guid? sourceDtId, string id, string name, bool? active, int page, int pageSize)
        {
            var query = this._dbContext.Area
                .Include(t => t.Responsible)
                .Include(t => t.Source)
                .Where(m => sourceDtId.HasValue ? m.SourceDtId == sourceDtId : m.Source is Site)
                .Where(m => !string.IsNullOrWhiteSpace(id) ? m.Id.Contains(id) : true)
                .Where(m => !string.IsNullOrWhiteSpace(name) ? m.Name.Contains(name) : true)
                .Where(m => active.HasValue ? m.Active == active.Value : true)
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

        public async Task<PagedResponse<OrgResponse>> GetProductionLineAsync(Guid? sourceDtId, string id, string name, bool? active, int page, int pageSize)
        {
            var query = this._dbContext.ProductionLine
                .Include(t => t.Responsible)
                .Include(t => t.Source)
                .Where(m => sourceDtId.HasValue ? m.SourceDtId == sourceDtId.Value : true)
                .Where(m => !string.IsNullOrWhiteSpace(id) ? m.Id.Contains(id) : true)
                .Where(m => !string.IsNullOrWhiteSpace(name) ? m.Name.Contains(name) : true)
                .Where(m => active.HasValue ? m.Active == active.Value : true)
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

        public async Task<PagedResponse<OrgResponse>> GetProductionUnitAsync(Guid? sourceDtId, string id, string name, bool? active, int page, int pageSize)
        {
            var query = this._dbContext.ProductionUnit
                .Include(t => t.Responsible)
                .Include(t => t.Source)
                .Where(m => sourceDtId.HasValue ? m.SourceDtId == sourceDtId.Value : true)
                .Where(m => !string.IsNullOrWhiteSpace(id) ? m.Id.Contains(id) : true)
                .Where(m => !string.IsNullOrWhiteSpace(name) ? m.Name.Contains(name) : true)
                .Where(m => active.HasValue ? m.Active == active.Value : true)
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
    }
}