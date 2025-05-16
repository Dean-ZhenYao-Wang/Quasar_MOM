using MediatR;
using MOM.Application.DTOs.Menu.Responses;
using MOM.Application.Features.Permission.Queries.GetMenuTree;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Application.Features.Permission.Queries.GetOrgPermissionLis
{
    public class GetOrgPermissionListQueryHandler(IOrgPermissionRepository orgPermissionRepository) : IRequestHandler<GetOrgPermissionListQuery, BaseResult<List<string>>>
    {
        public async Task<BaseResult<List<string>>> Handle(GetOrgPermissionListQuery request, CancellationToken cancellationToken)
        {
            return await orgPermissionRepository.GetOrgPermissionListAsync(request.OrgDtId);
        }
    }
}
