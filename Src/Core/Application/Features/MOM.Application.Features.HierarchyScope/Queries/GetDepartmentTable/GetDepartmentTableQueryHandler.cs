using MediatR;
using MOM.Application.DTOs.HierarchyScope.Responses;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;
using MOM.Domain.isa95.EquipmentHierarchy;

namespace MOM.Application.Features.HierarchyScope.Queries.GetDepartmentTable
{
    /// <summary>
    ///
    /// </summary>
    public class GetDepartmentTableQueryHandler(IHierarchyScopeRepository hierarchyScopeRepository) : IRequestHandler<GetDepartmentTableQuery, PagedResponse<OrgResponse>>
    {
        /// <summary>
        ///
        /// </summary>
        public async Task<PagedResponse<OrgResponse>> Handle(GetDepartmentTableQuery request, CancellationToken cancellationToken)
        {
            return await hierarchyScopeRepository.GetDepartmentListAsync(request.SourceDtId, request.Id, request.Name, request.Page, request.PageSize);
        }
    }
}