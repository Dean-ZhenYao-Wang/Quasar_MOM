using MediatR;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.HierarchyScope.Commands.DeleteHierarchyScope
{
    /// <summary>
    ///
    /// </summary>
    public class DeleteHierarchyScopeCommand : IRequest<BaseResult>
    {
        /// <summary>
        /// 要删除的组织DtId清单
        /// </summary>
        public Guid[] DtIds { get; set; } = [];
    }
}