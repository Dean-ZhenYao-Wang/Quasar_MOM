using MediatR;
using MOM.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Application.Features.Permission.Queries.GetOrgPermissionLis
{
    public class GetOrgPermissionListQuery : IRequest<BaseResult<List<string>>>
    {
        /// <summary>
        /// 指定组织的DtId
        /// </summary>
        public Guid OrgDtId { get; set; }
    }
}
