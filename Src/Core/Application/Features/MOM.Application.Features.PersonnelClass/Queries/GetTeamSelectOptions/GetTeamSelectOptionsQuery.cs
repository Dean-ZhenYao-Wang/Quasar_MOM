using MediatR;
using MOM.Application.DTOs.PersonnelClass.Responses;
using MOM.Application.Features.PersonnelClass.Queries.GetPagedPosition;
using MOM.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Application.Features.PersonnelClass.Queries.GetTeamSelectOptions
{
    public class GetTeamSelectOptionsQuery : IRequest<List<PersonnelClassResponse>>
    {
    }
}
