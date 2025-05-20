using MediatR;
using MOM.Application.DTOs.Personnel.Requests;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.Personnel.Commands.AddPerson
{
    public class AddPersonCommand : AddPersonRequest, IRequest<BaseResult>
    {
    }
}