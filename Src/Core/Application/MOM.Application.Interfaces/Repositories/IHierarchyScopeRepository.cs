using MOM.Application.DTOs.Common;
using MOM.Application.DTOs.HierarchyScope.Responses;
using MOM.Application.Wrappers;
using MOM.Domain.isa95.CommonObjectModels;

namespace MOM.Application.Interfaces.Repositories
{
    public interface IHierarchyScopeRepository : IGenericRepository<HierarchyScope>
    {
        Task AddAsync(HierarchyScope model, Guid? sourceDtId);
        Task DeleteAsync(Guid[] dtIds);
        Task<PagedResponse<OrgResponse>> GetOrgListAsync(Guid? sourceDtId, string? id, string? name, int page, int pageSize);
        Task<List<TreeNode<OrgResponse>>> GetOrgTreeAsync(Guid? sourceDtId);
    }
}
