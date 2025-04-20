using MOM.Domain.isa95.CommonObjectModels.Part2.Personnel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Application.DTOs.Department.Requests
{
    public class AddDepartmentRequest : DepartmentRequest
    {
        /// <summary>
        /// 上级菜单DtId
        /// </summary>
        public Guid? SourceDtId { get; set; }
        public override PersonnelClass ToPersonnelClass()
        {
            var pc = base.ToPersonnelClass();
            if (SourceDtId != null && SourceDtId.Value != Guid.Empty)
                pc.IncludesPropertiesOf.Add(new Domain.Common.Relationship.isa95.PersonnelClass.PersonnelClassIncludesPropertiesOfRelationship(SourceDtId.Value, pc.DtId));
            return pc;
        }
    }
}
