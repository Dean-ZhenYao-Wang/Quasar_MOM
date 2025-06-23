using MediatR;
using MOM.Application.DTOs.PersonnelClass.Requests;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.PersonnelClass.Commands.AddTeam
{
    /// <summary>
    ///
    /// </summary>
    public class AddTeamCommand : AddTeamRequest, IRequest<BaseResult>
    {
    }
}