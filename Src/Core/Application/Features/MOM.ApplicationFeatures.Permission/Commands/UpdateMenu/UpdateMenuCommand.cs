using MediatR;
using MOM.Application.DTOs.Menu.Requests;
using MOM.Application.Wrappers;

namespace MOM.ApplicationFeatures.Permission.Commands.UpdateMenu
{
    public class UpdateMenuCommand:UpdateMenuRequest,IRequest<BaseResult>
    {

    }
}
