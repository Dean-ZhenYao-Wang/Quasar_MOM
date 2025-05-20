namespace MOM.Application.DTOs.HierarchyScope.Requests
{
    public class UpdateOrgRequest : OrgRequest
    {
        /// <summary>
        /// 组织的数据库唯一Key
        /// </summary>
        public Guid DtId { get; set; }
    }
}
