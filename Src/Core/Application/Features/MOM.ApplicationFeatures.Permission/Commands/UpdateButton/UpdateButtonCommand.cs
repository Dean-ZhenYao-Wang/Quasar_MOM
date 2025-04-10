using MediatR;
using MOM.Application.DTOs.Menu.Requests;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.Permission.Commands.UpdateButton
{
    public class UpdateButtonCommand : UpdateButtonRequest, IRequest<BaseResult>;
}
