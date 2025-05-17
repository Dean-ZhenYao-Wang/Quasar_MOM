using MediatR;
using MOM.Application.DTOs.HierarchyScope.Responses;
using MOM.Application.Features.HierarchyScope.Queries.GetOrgTree;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Application.Features.HierarchyScope.Queries.GetOrgTable
{
    public class GetOrgTableQueryHandler(IHierarchyScopeContainsRelationshipRepository hierarchyScopeContainsRelationshipRepository) : IRequestHandler<GetOrgTableQuery, PagedResponse<OrgResponse>>
    {
        public async Task<PagedResponse<OrgResponse>> Handle(GetOrgTableQuery request, CancellationToken cancellationToken)
        {
            return await hierarchyScopeContainsRelationshipRepository.GetOrgListAsync(request.SourceDtId, request.Id, request.Name, request.Page, request.PageSize);
        }
    }
}
