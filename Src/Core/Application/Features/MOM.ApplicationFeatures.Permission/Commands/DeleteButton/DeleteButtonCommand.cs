using MediatR;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.Permission.Commands.DeleteButton
{
    public class DeleteButtonCommand : IRequest<BaseResult>
    {
        public Guid[] DtIds { get; set; }
    }
}