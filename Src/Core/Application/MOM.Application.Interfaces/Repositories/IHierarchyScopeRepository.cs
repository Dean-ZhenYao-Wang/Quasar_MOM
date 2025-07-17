using Microsoft.EntityFrameworkCore.ChangeTracking;
using MOM.Application.DTOs.HierarchyScope.Responses;
using MOM.Application.Wrappers;
using MOM.Domain.isa95.CommonObjectModels;
using MOM.Domain.isa95.EquipmentHierarchy;

namespace MOM.Application.Interfaces.Repositories
{
    public interface IHierarchyScopeRepository : IGenericRepository<HierarchyScope>
    {
        Task<EntityEntry<TEntity>> AddAsync<TEntity>(TEntity org) where TEntity : HierarchyScope;

        /// <summary>
        /// 批量删除指定设备角色层次
        /// </summary>
        /// <param name="dtIds"></param>
        /// <returns></returns>
        Task DeleteAsync(Guid[] dtIds);
        Task<Enterprise> GetEnterpriseByKeyAsync(Guid dtId);

        /// <summary>
        /// 查询设备角色层次清单
        /// </summary>
        /// <param name="sourceDtId"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        Task<PagedResponse<OrgResponse>> GetOrgListAsync(Guid? sourceDtId, string? id, string? name, int page, int pageSize);
    }
}