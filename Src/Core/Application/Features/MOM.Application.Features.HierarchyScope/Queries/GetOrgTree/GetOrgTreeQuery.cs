using MediatR;
using MOM.Application.DTOs.Common;
using MOM.Application.DTOs.HierarchyScope.Responses;

namespace MOM.Application.Features.HierarchyScope.Queries.GetOrgTree
{
    /// <summary>
    ///
    /// </summary>
    public class GetOrgTreeQuery : IRequest<List<TreeNode<OrgResponse>>>
    {
        /// <summary>
        /// 上级菜单DtId
        /// </summary>
        public Guid? SourceDtId { get; set; }
    }
}