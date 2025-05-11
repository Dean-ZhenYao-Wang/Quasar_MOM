using MediatR;
using MOM.Application.DTOs.Personnel;
using MOM.Application.DTOs.Resource.Responses;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;
using MOM.Domain.isa95.CommonObjectModels.Part2.Personnel;
using System.Threading;
using System.Threading.Tasks;

namespace MOM.Application.Features.Personnel.Queries.GetProperties
{
    public class GetPropertiesQueryHandler(IPersonRepository personRepository, ITranslator translator) : IRequestHandler<GetPropertiesQuery, List<ResourcePropertyResponse>>
    {
        public async Task<List<ResourcePropertyResponse>> Handle(GetPropertiesQuery request, CancellationToken cancellationToken)
        {
            Person person = await personRepository.GetByIdAsync(request.DtId);
            return person.GetProperties();
        }
    }
}
