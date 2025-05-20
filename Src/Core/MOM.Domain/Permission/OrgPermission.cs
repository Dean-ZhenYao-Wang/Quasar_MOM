using MOM.Domain.isa95.CommonObjectModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MOM.Domain.Permission
{
    /// <summary>
    /// 组织的权限,可以是对菜单的限制,也可以是对按钮的限制
    /// </summary>
    public class OrgPermission
    {
        [Key]
        public Guid DtId { get; set; } = Guid.NewGuid();

        public string MenuButtonId { get; set; }
        public Guid OrgDtId { get; set; }

        [ForeignKey(nameof(OrgDtId))]
        public virtual HierarchyScope Org { get; set; }
    }
}