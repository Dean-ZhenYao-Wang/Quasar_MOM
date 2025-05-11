using MediatR;
using MOM.Application.DTOs.Common;
using MOM.Application.DTOs.HierarchyScope.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Application.Features.HierarchyScope.Queries.GetOrgTree
{
    public class GetOrgTreeQuery:IRequest<List<TreeNode<OrgResponse>>>
    {
        /// <summary>
        /// 上级菜单DtId
        /// </summary>
        public Guid? SourceDtId { get; set; }
    }
}
