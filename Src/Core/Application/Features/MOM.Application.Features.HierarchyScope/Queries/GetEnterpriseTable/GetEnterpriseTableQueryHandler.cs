using MediatR;
using MOM.Application.DTOs.HierarchyScope.Responses;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;
using MOM.Domain.isa95.EquipmentHierarchy;

namespace MOM.Application.Features.HierarchyScope.Queries.GetEnterpriseTable
{
    /// <summary>
    ///
    /// </summary>
    public class GetEnterpriseTableQueryHandler(IHierarchyScopeRepository hierarchyScopeRepository) : IRequestHandler<GetEnterpriseTableQuery, PagedResponse<OrgResponse>>
    {
        /// <summary>
        ///
        /// </summary>
        public async Task<PagedResponse<OrgResponse>> Handle(GetEnterpriseTableQuery request, CancellationToken cancellationToken)
        {
            return await hierarchyScopeRepository.GetEnterpriseListAsync(request.SourceDtId, request.Id, request.Name, request.Page, request.PageSize);
        }
    }
}