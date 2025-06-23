using MOM.Application.DTOs.HierarchyScope.Requests;

namespace MOM.Application.DTOs.HierarchyScope.Responses
{
    /// <summary>
    ///
    /// </summary>
    public class OrgResponse : UpdateOrgRequest
    {
        /// <summary>
        /// 所属组织名称
        /// </summary>
        public string? SourceName { get; set; }

        /// <summary>
        /// 下辖组织清单
        /// </summary>
        public List<OrgResponse> Children { get; set; } = new List<OrgResponse>();

        /// <summary>
        /// 负责人姓名
        /// </summary>
        public string? ResponsibleName { get; set; }

        /// <summary>
        /// 路径
        /// </summary>
        public string FullPath { get; set; }
    }
}