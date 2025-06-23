using MediatR;
using MOM.Application.Wrappers;

namespace MOM.Application.DTOs.Common
{
    /// <summary>
    ///
    /// </summary>
    public class DeleteCommand : IRequest<BaseResult>
    {
        /// <summary>
        /// 需要被删除的对象的DtId清单
        /// </summary>
        public Guid[] DtIds { get; set; }
    }
}