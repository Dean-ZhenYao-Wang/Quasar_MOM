using MOM.Domain.isa95.CommonObjectModels.Part2.Personnel;

namespace MOM.Application.DTOs.Personnel.Requests
{
    public class UpdatePersonRequest : AddPersonRequest
    {
        public override Person ToPerson()
        {
            Person person = base.ToPerson();
            person.DtId = DtId;
            return person;
        }
    }
}