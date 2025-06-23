using MediatR;
using MOM.Application.DTOs.HierarchyScope.Responses;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.HierarchyScope.Queries.GetEnterpriseTable
{
    /// <summary>
    ///
    /// </summary>
    public class GetEnterpriseTableQueryHandler(IHierarchyScopeContainsRelationshipRepository hierarchyScopeContainsRelationshipRepository) : IRequestHandler<GetEnterpriseTableQuery, PagedResponse<OrgResponse>>
    {
        /// <summary>
        ///
        /// </summary>
        public async Task<PagedResponse<OrgResponse>> Handle(GetEnterpriseTableQuery request, CancellationToken cancellationToken)
        {
            return await hierarchyScopeContainsRelationshipRepository.GetEnterpriseListAsync(request.Id, request.Name, request.Page, request.PageSize);
        }
    }
}