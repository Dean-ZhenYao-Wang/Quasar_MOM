using MediatR;
using MOM.Application.DTOs.Menu.Requests;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.Permission.Commands.UpdateMenu
{
    /// <summary>
    ///
    /// </summary>
    public class UpdateMenuCommand : UpdateMenuRequest, IRequest<BaseResult>
    {
    }
}