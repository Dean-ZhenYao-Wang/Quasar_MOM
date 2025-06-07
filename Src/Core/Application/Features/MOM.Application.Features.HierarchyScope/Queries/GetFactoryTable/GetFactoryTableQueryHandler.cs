using MediatR;
using MOM.Application.DTOs.HierarchyScope.Responses;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.HierarchyScope.Queries.GetFactoryTable
{
    public class GetFactoryTableQueryHandler(IHierarchyScopeContainsRelationshipRepository hierarchyScopeContainsRelationshipRepository) : IRequestHandler<GetFactoryTableQuery, PagedResponse<OrgResponse>>
    {
        public async Task<PagedResponse<OrgResponse>> Handle(GetFactoryTableQuery request, CancellationToken cancellationToken)
        {
            return await hierarchyScopeContainsRelationshipRepository.GetFactoryListAsync(request.Id, request.Name, request.Page, request.PageSize);
        }
    }
}