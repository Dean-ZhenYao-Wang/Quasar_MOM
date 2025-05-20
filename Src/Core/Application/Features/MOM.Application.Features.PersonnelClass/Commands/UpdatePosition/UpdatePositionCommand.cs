using MediatR;
using MOM.Application.Features.PersonnelClass.Commands.AddPsitoion;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.PersonnelClass.Commands.UpdatePosition
{
    public class UpdatePositionCommand : AddPositionCommand, IRequest<BaseResult>
    {
        /// <summary>
        /// 职位的数据库唯一主键
        /// </summary>
        public Guid DtId { get; set; }
    }
}