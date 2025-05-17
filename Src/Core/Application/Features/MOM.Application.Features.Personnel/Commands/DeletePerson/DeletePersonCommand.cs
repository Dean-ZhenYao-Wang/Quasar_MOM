using MediatR;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.Personnel.Commands.DeletePerson
{
    public class DeletePersonCommand : IRequest<BaseResult>
    {
        /// <summary>
        /// 需要被删除的人员的DtId清单
        /// </summary>
        public Guid[] DtIds { get; set; }
    }
}
