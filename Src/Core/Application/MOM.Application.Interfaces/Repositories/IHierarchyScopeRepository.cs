using Microsoft.EntityFrameworkCore.ChangeTracking;
using MOM.Application.DTOs.HierarchyScope.Responses;
using MOM.Application.Wrappers;
using MOM.Domain.isa95.CommonObjectModels;
using MOM.Domain.isa95.EquipmentHierarchy;

namespace MOM.Application.Interfaces.Repositories
{
    public interface IHierarchyScopeRepository : IGenericRepository<HierarchyScope>
    {
        Task<EntityEntry<Area>> AddAreaAsync(Area area);
        Task<EntityEntry<Area>> AddDepartmentAsync(Area area);
        Task<EntityEntry<Enterprise>> AddEnterpriseAsync(Enterprise enterprise);
        Task<EntityEntry<Site>> AddFactoryAsync(Site site);
        Task<EntityEntry<ProductionLine>> AddProductionLineAsync(ProductionLine productionLine);
        Task<EntityEntry<ProductionUnit>> AddProductionUnitAsync(ProductionUnit productionUnit);

        /// <summary>
        /// 批量删除指定设备角色层次
        /// </summary>
        /// <param name="dtIds"></param>
        /// <returns></returns>
        Task DeleteAsync(Guid[] dtIds);
        Task<Area> GetAreaByKeyAsync(Guid dtId);
        Task<PagedResponse<OrgResponse>> GetDepartmentListAsync(Guid? sourceDtId, string? id, string? name, int page, int pageSize);
        Task<Enterprise> GetEnterpriseByKeyAsync(Guid dtId);
        Task<PagedResponse<OrgResponse>> GetEnterpriseListAsync(Guid? sourceDtId, string? id, string? name, int page, int pageSize);
        Task<PagedResponse<OrgResponse>> GetFactoryListAsync(Guid? sourceDtId, string? id, string? name, int page, int pageSize);
        Task<PagedResponse<OrgResponse>> GetProductionLineAsync(Guid? sourceDtId, string? id, string? name, bool? active, int page, int pageSize);
        Task<ProductionLine> GetProductionLineByKeyAsync(Guid dtId);
        Task<PagedResponse<OrgResponse>> GetProductionUnitAsync(Guid? sourceDtId, string? id, string? name, bool? active, int page, int pageSize);
        Task<ProductionUnit> GetProductionUnitByKeyAsync(Guid dtId);
        Task<Site> GetSiteByKeyAsync(Guid dtId);
        Task<PagedResponse<OrgResponse>> GetAreaListAsync(Guid? sourceDtId, string? id, string? name, bool? active, int page, int pageSize);
    }
}