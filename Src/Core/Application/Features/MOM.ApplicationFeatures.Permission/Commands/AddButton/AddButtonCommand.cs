using MediatR;
using MOM.Application.DTOs.Menu.Requests;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.Permission.Commands.AddButton
{
    public class AddButtonCommand:ButtonRequest, IRequest<BaseResult>
    {

    }
}
