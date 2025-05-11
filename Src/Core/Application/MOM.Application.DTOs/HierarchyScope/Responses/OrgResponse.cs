using Microsoft.CodeAnalysis.CSharp.Syntax;
using MOM.Application.DTOs.HierarchyScope.Requests;
using MOM.Domain.isa95.CommonObjectModels.Part2.Personnel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Application.DTOs.HierarchyScope.Responses
{
    public class OrgResponse: UpdateOrgRequest
    {
        /// <summary>
        /// 所属组织DtId
        /// </summary>
        public Guid? SourceDtId { get; set; }
        /// <summary>
        /// 所属组织名称
        /// </summary>
        public string SourceName { get; set; }
        public List<OrgResponse> Children { get; set; } = new List<OrgResponse>();
    }
}
