using MediatR;
using MOM.Application.DTOs.PersonnelClass.Responses;

namespace MOM.Application.Features.PersonnelClass.Queries.GetTeamSelectOptions
{
    public class GetTeamSelectOptionsQuery : IRequest<List<PersonnelClassResponse>>
    {
    }
}