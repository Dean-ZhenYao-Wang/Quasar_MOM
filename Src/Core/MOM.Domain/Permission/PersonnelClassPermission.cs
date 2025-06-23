using MOM.Domain.isa95.CommonObjectModels.Part2.Personnel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MOM.Domain.Permission
{
    /// <summary>
    /// 人员类的权限,可以是对菜单的限制,也可以是对按钮的限制
    /// </summary>
    public class PersonnelClassPermission
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
        /// 人员类的主键
        /// </summary>
        public Guid PersonnelClassDtId { get; set; }

        /// <summary>
        /// 人员类
        /// </summary>
        [ForeignKey(nameof(PersonnelClassDtId))]
        public virtual PersonnelClass PersonnelClass { get; set; }
    }
}