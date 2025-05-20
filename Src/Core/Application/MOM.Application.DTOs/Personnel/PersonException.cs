using MOM.Application.DTOs.Resource.Responses;
using MOM.Domain.isa95.CommonObjectModels.Part2.Personnel;

namespace MOM.Application.DTOs.Personnel
{
    public static class PersonException
    {
        public static List<ResourcePropertyResponse> GetProperties(this Person person)
        {
            return person.HasValuesOf.Select(m => new ResourcePropertyResponse(m.Target)).ToList();
        }
    }
}