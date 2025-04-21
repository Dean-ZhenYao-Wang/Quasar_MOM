using MOM.Application.DTOs.Personnel.Requests;
using MOM.Domain.isa95.CommonObjectModels.Part2.Personnel;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MOM.Application.DTOs.Department.Requests
{
    public class DepartmentRequest : PersonnelClassRequest
    {
        /// <summary>
        /// 负责人的DtId
        /// </summary>
        [Required]
        public Guid? ResponsibleDtId { get; set; }

        public virtual PersonnelClass ToPersonnelClass()
        {
            PersonnelClass personClass = new PersonnelClass(this.Id,"部门");
            personClass.ResponsibleDtId = this.ResponsibleDtId;
            return personClass;
        }
    }
}
