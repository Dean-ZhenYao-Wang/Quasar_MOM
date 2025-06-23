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
        /// <summary>
        /// 主键
        /// </summary>
        [Key]
        public Guid DtId { get; set; } = Guid.NewGuid();

        /// <summary>
        /// 菜单或按钮的编号
        /// </summary>
        public string MenuButtonId { get; set; }

        /// <summary>
        /// 组织的主键
        /// </summary>
        public Guid OrgDtId { get; set; }

        /// <summary>
        /// 组织
        /// </summary>
        [ForeignKey(nameof(OrgDtId))]
        public virtual HierarchyScope Org { get; set; }
    }
}