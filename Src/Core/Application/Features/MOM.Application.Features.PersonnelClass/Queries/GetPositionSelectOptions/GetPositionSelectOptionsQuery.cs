using MediatR;
using MOM.Application.DTOs.PersonnelClass.Responses;
using MOM.Application.Features.PersonnelClass.Queries.GetTeamSelectOptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Application.Features.PersonnelClass.Queries.GetPositionSelectOptions
{
    public class GetPositionSelectOptionsQuery : IRequest<List<PersonnelClassResponse>>
    {
    }
}
