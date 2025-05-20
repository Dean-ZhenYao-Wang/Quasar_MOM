using MediatR;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.Permission.Commands.DeleteMenu
{
    public class DeleteMenuCommand : IRequest<BaseResult>
    {
        public Guid[] DtIds { get; set; }
    }
}