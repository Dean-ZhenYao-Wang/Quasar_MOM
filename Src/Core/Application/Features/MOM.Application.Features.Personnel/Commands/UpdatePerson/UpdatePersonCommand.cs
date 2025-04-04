using MediatR;
using MOM.Application.DTOs.Personnel.Requests;
using MOM.Application.Features.Personnel.Commands.AddPerson;
using MOM.Application.Wrappers;
using MOM.Domain.Common.EnumType;
using MOM.Domain.isa95.CommonObjectModels.Part2.Personnel;

namespace MOM.Application.Features.Personnel.Commands.UpdatePerson
{
    public class UpdatePersonCommand : UpdatePersonRequest, IRequest<BaseResult>
    {
    }
}
