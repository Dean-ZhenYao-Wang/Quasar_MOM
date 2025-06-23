using MediatR;
using MOM.Application.DTOs.Personnel.Requests;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.Personnel.Commands.AddPerson
{
    /// <summary>
    ///
    /// </summary>
    public class AddPersonCommand : AddPersonRequest, IRequest<BaseResult>
    {
    }
}