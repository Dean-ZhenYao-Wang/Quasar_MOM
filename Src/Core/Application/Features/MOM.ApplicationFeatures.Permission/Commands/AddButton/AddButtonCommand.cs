using MediatR;
using Microsoft.EntityFrameworkCore.Query.Internal;
using MOM.Application.DTOs.Menu.Requests;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.Permission.Commands.AddButton
{
    public class AddButtonCommand:AddButtonRequest, IRequest<BaseResult>;
}
