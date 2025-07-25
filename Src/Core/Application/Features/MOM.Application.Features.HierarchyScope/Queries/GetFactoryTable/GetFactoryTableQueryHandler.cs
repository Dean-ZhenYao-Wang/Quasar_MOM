using MediatR;
using MOM.Application.DTOs.HierarchyScope.Responses;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.HierarchyScope.Queries.GetFactoryTable
{
    /// <summary>
    ///
    /// </summary>
    public class GetFactoryTableQueryHandler(IHierarchyScopeRepository hierarchyScopeRepository) : IRequestHandler<GetFactoryTableQuery, PagedResponse<OrgResponse>>
    {
        /// <summary>
        ///
        /// </summary>
        public async Task<PagedResponse<OrgResponse>> Handle(GetFactoryTableQuery request, CancellationToken cancellationToken)
        {
            return await hierarchyScopeRepository.GetFactoryListAsync(request.SourceDtId,request.Id, request.Name, request.Page, request.PageSize);
        }
    }
}