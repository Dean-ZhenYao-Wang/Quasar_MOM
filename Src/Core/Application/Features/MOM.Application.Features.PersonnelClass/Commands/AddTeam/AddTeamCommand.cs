using MediatR;
using MOM.Application.DTOs.PersonnelClass.Requests;
using MOM.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Application.Features.PersonnelClass.Commands.AddTeam
{
    public class AddTeamCommand : AddTeamRequest, IRequest<BaseResult>
    {
    }
}
