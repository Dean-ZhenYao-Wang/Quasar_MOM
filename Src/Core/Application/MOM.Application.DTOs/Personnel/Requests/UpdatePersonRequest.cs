using MOM.Domain.isa95.CommonObjectModels.Part2.Personnel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
