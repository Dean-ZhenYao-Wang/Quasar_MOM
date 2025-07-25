using MediatR;
using MOM.Application.DTOs.HierarchyScope.Responses;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.HierarchyScope.Queries.GetProductionLineTable
{
    /// <summary>
    ///
    /// </summary>
    public class GetProductionLineTableQueryHandler(IHierarchyScopeRepository hierarchyScopeRepository) : IRequestHandler<GetProductionLineTableQuery, PagedResponse<OrgResponse>>
    {
        /// <summary>
        ///
        /// </summary>
        public async Task<PagedResponse<OrgResponse>> Handle(GetProductionLineTableQuery request, CancellationToken cancellationToken)
        {
            return await hierarchyScopeRepository.GetProductionLineAsync(request.SourceDtId, request.Id, request.Name, request.Active, request.Page, request.PageSize);
        }
    }
}