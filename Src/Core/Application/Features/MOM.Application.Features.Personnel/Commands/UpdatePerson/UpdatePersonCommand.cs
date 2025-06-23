using MediatR;
using MOM.Application.DTOs.Personnel.Requests;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.Personnel.Commands.UpdatePerson
{
    /// <summary>
    ///
    /// </summary>
    public class UpdatePersonCommand : UpdatePersonRequest, IRequest<BaseResult>
    {
    }
}