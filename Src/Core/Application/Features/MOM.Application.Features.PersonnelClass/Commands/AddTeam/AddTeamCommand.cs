using MediatR;
using MOM.Application.DTOs.PersonnelClass.Requests;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.PersonnelClass.Commands.AddTeam
{
    public class AddTeamCommand : AddTeamRequest, IRequest<BaseResult>
    {
    }
}