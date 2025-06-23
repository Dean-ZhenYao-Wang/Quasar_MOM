using MediatR;
using MOM.Application.DTOs.PersonnelClass.Responses;

namespace MOM.Application.Features.PersonnelClass.Queries.GetPositionSelectOptions
{
    public class GetPositionSelectOptionsQuery : IRequest<List<PersonnelClassResponse>>
    {
    }
}