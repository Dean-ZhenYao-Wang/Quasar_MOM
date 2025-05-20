using MediatR;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.HierarchyScope.Commands.DeleteOrg
{
    public class DeleteOrgCommand : IRequest<BaseResult>
    {
        /// <summary>
        /// 要删除的组织DtId清单
        /// </summary>
        public Guid[] DtIds { get; set; }
    }
}