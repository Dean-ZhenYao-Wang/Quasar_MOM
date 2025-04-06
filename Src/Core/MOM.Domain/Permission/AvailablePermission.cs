using MOM.Domain.isa95.CommonObjectModels.Part2.Personnel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MOM.Domain.Permission
{
    /// <summary>
    /// 针对个人的权限,可以是对菜单的限制,也可以是对按钮的限制
    /// </summary>
    public class AvailablePermission
    {
        [Key]
        public Guid DtId { get; set; } = Guid.NewGuid();
        public string MenuButtonId { get; set; }
        /// <summary>
        /// 是否可用,用来做单独的权限的不可用限制,用来进行差集计算
        /// </summary>
        public bool Available { get; set; }
        [ForeignKey(nameof(PersonDtId))]
        public Guid PersonDtId { get; set; }
        public virtual Person Person { get; set; }
    }
}
