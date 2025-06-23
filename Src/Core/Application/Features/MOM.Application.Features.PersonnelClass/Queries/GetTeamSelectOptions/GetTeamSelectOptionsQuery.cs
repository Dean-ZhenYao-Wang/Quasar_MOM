using MediatR;
using MOM.Application.DTOs.PersonnelClass.Responses;

namespace MOM.Application.Features.PersonnelClass.Queries.GetTeamSelectOptions
{
    /// <summary>
    ///
    /// </summary>
    public class GetTeamSelectOptionsQuery : IRequest<List<PersonnelClassResponse>>
    {
    }
}