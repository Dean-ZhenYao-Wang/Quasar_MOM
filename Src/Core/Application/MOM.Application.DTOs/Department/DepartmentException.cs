using MOM.Application.DTOs.Department.Responses;
using MOM.Domain.isa95.CommonObjectModels.Part2.Personnel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Application.DTOs.Department
{
    public static class DepartmentException
    {
        public static DepartmentResponse ToDepartmentResponse(this PersonnelClass personnelClass)
        {
            DepartmentResponse departmentResponse = new DepartmentResponse()
            {
                DtId = personnelClass.DtId,
                Id = personnelClass.Id,
                ResponsibleDtId = personnelClass.ResponsibleDtId,
                Children = personnelClass.IncludesPropertiesOf.Select(m=>m.Target.ToDepartmentResponse()).OrderBy(m => m.Id).ToList(),
            };

            return departmentResponse;
        }
    }
}
