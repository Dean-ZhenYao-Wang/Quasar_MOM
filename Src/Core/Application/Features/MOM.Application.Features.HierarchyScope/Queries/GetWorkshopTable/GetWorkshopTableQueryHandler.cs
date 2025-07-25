using MediatR;
using MOM.Application.DTOs.HierarchyScope.Responses;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.HierarchyScope.Queries.GetWorkshopTable
{
    /// <summary>
    ///
    /// </summary>
    public class GetWorkshopTableQueryHandler(IHierarchyScopeRepository hierarchyScopeRepository) : IRequestHandler<GetWorkshopTableQuery, PagedResponse<OrgResponse>>
    {
        /// <summary>
        ///
        /// </summary>
        public async Task<PagedResponse<OrgResponse>> Handle(GetWorkshopTableQuery request, CancellationToken cancellationToken)
        {
            return await hierarchyScopeRepository.GetWorkshopListAsync(request.Id, request.Name, request.Active, request.Page, request.PageSize);
        }
    }
}