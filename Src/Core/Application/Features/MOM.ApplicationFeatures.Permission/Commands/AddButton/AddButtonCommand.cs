using MediatR;
using MOM.Application.DTOs.Menu.Requests;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.Permission.Commands.AddButton
{
    /// <summary>
    ///
    /// </summary>
    public class AddButtonCommand : AddButtonRequest, IRequest<BaseResult>;
}