using MOM.Domain.isa95.CommonObjectModels.Part2.Personnel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Domain.Permission
{
    /// <summary>
    /// 职位的权限,可以是对菜单的限制,也可以是对按钮的限制
    /// </summary>
    public class PersonnelClassPermission
    {
        [Key]
        public Guid DtId { get; set; } = Guid.NewGuid();
        public string MenuButtonId { get; set; }
        public Guid PersonnelClassDtId { get; set; }
        [ForeignKey(nameof(PersonnelClassDtId))]
        public virtual PersonnelClass PersonnelClass { get; set; }
    }
}
