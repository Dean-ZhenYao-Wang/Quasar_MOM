using MediatR;
using MOM.Application.DTOs.Personnel.Responses;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.Personnel.Queries.GetPagedListPerson
{
    public class GetPagedListPersonQuery : PaginationRequestParameter, IRequest<PagedResponse<PersonResponse>>
    {
    }
}
