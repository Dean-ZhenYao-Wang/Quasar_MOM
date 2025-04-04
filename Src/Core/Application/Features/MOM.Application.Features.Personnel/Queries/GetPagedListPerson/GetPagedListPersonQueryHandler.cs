using System.Threading;
using System.Threading.Tasks;
using MediatR;
using MOM.Application.DTOs.Personnel.Responses;
using MOM.Application.DTOs.Products;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.Personnel.Queries.GetPagedListPerson
{
    public class GetPagedListPersonQueryHandler(IPersonRepository personRepository) : IRequestHandler<GetPagedListPersonQuery, PagedResponse<PersonResponse>>
    {
        public async Task<PagedResponse<PersonResponse>> Handle(GetPagedListPersonQuery request, CancellationToken cancellationToken)
        {
            return await personRepository.GetPagedListAsync(request.PageNumber, request.PageSize);
        }
    }
}
