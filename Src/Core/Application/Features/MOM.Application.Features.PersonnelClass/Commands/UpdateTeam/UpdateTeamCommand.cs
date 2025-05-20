using MediatR;
using MOM.Application.DTOs.PersonnelClass.Requests;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.PersonnelClass.Commands.UpdateTeam
{
    public class UpdateTeamCommand : UpdateTeamRequest, IRequest<BaseResult>
    {
    }
}