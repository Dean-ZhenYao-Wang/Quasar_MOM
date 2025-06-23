using MediatR;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.Permission.Queries.GetOrgPermissionLis
{
    /// <summary>
    ///
    /// </summary>
    public class GetOrgPermissionListQuery : IRequest<BaseResult<List<string>>>
    {
        /// <summary>
        /// 指定组织的DtId
        /// </summary>
        public Guid OrgDtId { get; set; }
    }
}