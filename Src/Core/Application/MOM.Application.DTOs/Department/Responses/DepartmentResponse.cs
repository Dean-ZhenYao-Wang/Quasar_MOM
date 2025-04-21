using Microsoft.CodeAnalysis.CSharp.Syntax;
using MOM.Application.DTOs.Department.Requests;
using MOM.Domain.isa95.CommonObjectModels.Part2.Personnel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Application.DTOs.Department.Responses
{
    public class DepartmentResponse: UpdateDepartmentRequest
    {
        /// <summary>
        /// 上级菜单DtId
        /// </summary>
        public Guid? SourceDtId { get; set; }
        public List<DepartmentResponse> Children { get; set; } = new List<DepartmentResponse>();
    }
}
