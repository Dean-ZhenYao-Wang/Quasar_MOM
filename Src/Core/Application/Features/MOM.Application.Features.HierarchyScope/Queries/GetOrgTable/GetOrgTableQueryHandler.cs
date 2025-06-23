using MediatR;
using MOM.Application.DTOs.HierarchyScope.Responses;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.HierarchyScope.Queries.GetOrgTable
{
    /// <summary>
    ///
    /// </summary>
    public class GetOrgTableQueryHandler(IHierarchyScopeContainsRelationshipRepository hierarchyScopeContainsRelationshipRepository) : IRequestHandler<GetOrgTableQuery, PagedResponse<OrgResponse>>
    {
        /// <summary>
        ///
        /// </summary>
        public async Task<PagedResponse<OrgResponse>> Handle(GetOrgTableQuery request, CancellationToken cancellationToken)
        {
            return await hierarchyScopeContainsRelationshipRepository.GetOrgListAsync(request.SourceDtId, request.Id, request.Name, request.Page, request.PageSize);
        }
    }
}