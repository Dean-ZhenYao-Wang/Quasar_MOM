using MOM.Application.DTOs.Common;
using MOM.Application.DTOs.HierarchyScope.Responses;
using MOM.Application.Wrappers;
using MOM.Domain.Common.Relationship.isa95.HierarchyScope;
using MOM.Domain.isa95.CommonObjectModels;

namespace MOM.Application.Interfaces.Repositories
{
    public interface IHierarchyScopeContainsRelationshipRepository : IGenericRepository<HierarchyScopeContainsRelationship>
    {
        Task AddAsync(Guid? parentId, HierarchyScope newNode);
        Task<string> GetFullPathAsync(Guid nodeId);

        Task<List<TreeNode<OrgResponse>>> GetOrgTreeAsync(Guid? sourceDtId);
        Task MoveNodeAsync(Guid nodeId, Guid? newParentId);
    }
}