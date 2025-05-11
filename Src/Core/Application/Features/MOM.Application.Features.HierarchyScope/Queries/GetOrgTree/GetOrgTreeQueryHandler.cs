using MediatR;
using MOM.Application.DTOs.Common;
using MOM.Application.DTOs.HierarchyScope.Responses;
using MOM.Application.Interfaces.Repositories;

namespace MOM.Application.Features.HierarchyScope.Queries.GetOrgTree
{
    public class GetOrgTreeQueryHandler(IHierarchyScopeRepository hierarchyScopeRepository) : IRequestHandler<GetOrgTreeQuery, List<TreeNode<OrgResponse>>>
    {
        public async Task<List<TreeNode<OrgResponse>>> Handle(GetOrgTreeQuery request, CancellationToken cancellationToken)
        {
            return await hierarchyScopeRepository.GetOrgTreeAsync(request.SourceDtId);
        }
    }
}
