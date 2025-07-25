using MediatR;
using MOM.Application.DTOs.HierarchyScope.Responses;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.HierarchyScope.Queries.GetProductionLineTable
{
    /// <summary>
    ///
    /// </summary>
    public class GetProductionUnitTableQueryHandler(IHierarchyScopeRepository hierarchyScopeRepository) : IRequestHandler<GetProductionUnitTableQuery, PagedResponse<OrgResponse>>
    {
        /// <summary>
        ///
        /// </summary>
        public async Task<PagedResponse<OrgResponse>> Handle(GetProductionUnitTableQuery request, CancellationToken cancellationToken)
        {
            return await hierarchyScopeRepository.GetProductionUnitAsync(request.SourceDtId, request.Id, request.Name, request.Active, request.Page, request.PageSize);
        }
    }
}