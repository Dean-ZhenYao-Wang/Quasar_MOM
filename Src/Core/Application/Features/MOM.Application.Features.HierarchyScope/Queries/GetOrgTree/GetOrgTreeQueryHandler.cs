using MediatR;
using MOM.Application.DTOs.Common;
using MOM.Application.DTOs.HierarchyScope.Responses;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;
using MOM.Domain.Common.Relationship.isa95.HierarchyScope;

namespace MOM.Application.Features.HierarchyScope.Queries.GetOrgTree
{
    public class GetOrgTreeQueryHandler(IHierarchyScopeContainsRelationshipRepository hierarchyScopeContainsRelationshipRepository) : IRequestHandler<GetOrgTreeQuery, List<TreeNode<OrgResponse>>>
    {
        public async Task<List<TreeNode<OrgResponse>>> Handle(GetOrgTreeQuery request, CancellationToken cancellationToken)
        {
            return await hierarchyScopeContainsRelationshipRepository.GetOrgTreeAsync(request.SourceDtId);
        }
    }
}
