using MediatR;
using MOM.Application.Interfaces.Repositories;
using MOM.Domain.isa95.CommonObjectModels.Part2.Personnel;

namespace MOM.Application.Features.Personnel.Queries.GetResponsibles
{
    public class GetPropertiesQueryHandler(IPersonRepository personRepository) : IRequestHandler<GetResponsiblesQuery, List<Person>>
    {
        public async Task<List<Person>> Handle(GetResponsiblesQuery request, CancellationToken cancellationToken)
        {
            return await personRepository.GetResponsiblesAsync();
        }
    }
}