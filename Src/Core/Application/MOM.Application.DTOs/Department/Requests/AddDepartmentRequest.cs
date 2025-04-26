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
        /// 上级部门DtId
        /// </summary>
        public Guid? SourceDtId { get; set; }
    }
}
