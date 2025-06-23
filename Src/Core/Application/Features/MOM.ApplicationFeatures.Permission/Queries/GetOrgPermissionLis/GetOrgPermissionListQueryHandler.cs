using MediatR;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.Permission.Queries.GetOrgPermissionLis
{
    /// <summary>
    ///
    /// </summary>
    public class GetOrgPermissionListQueryHandler(IOrgPermissionRepository orgPermissionRepository) : IRequestHandler<GetOrgPermissionListQuery, BaseResult<List<string>>>
    {
        /// <summary>
        ///
        /// </summary>
        public async Task<BaseResult<List<string>>> Handle(GetOrgPermissionListQuery request, CancellationToken cancellationToken)
        {
            return await orgPermissionRepository.GetOrgPermissionListAsync(request.OrgDtId);
        }
    }
}