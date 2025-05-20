using MOM.Application.DTOs.Common;
using MOM.Application.DTOs.HierarchyScope.Responses;
using MOM.Application.Wrappers;
using MOM.Domain.Common.Relationship.isa95.HierarchyScope;

namespace MOM.Application.Interfaces.Repositories
{
    public interface IHierarchyScopeContainsRelationshipRepository : IGenericRepository<HierarchyScopeContainsRelationship>
    {
        Task<PagedResponse<OrgResponse>> GetOrgListAsync(Guid? sourceDtId, string id, string name, int page, int pageSize);

        Task<List<TreeNode<OrgResponse>>> GetOrgTreeAsync(Guid? sourceDtId);
    }
}