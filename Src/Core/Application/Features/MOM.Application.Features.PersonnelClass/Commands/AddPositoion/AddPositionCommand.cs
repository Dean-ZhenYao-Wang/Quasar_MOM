using MediatR;
using MOM.Application.DTOs.PersonnelClass.Requests;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.PersonnelClass.Commands.AddPsitoion
{
    public class AddPositionCommand : AddPositionRequest, IRequest<BaseResult>
    {
    }
}