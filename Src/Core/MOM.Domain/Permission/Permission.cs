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
    public class Permission
    {
        [Key]
        public Guid DtId { get; set; } = Guid.NewGuid();
        public string MenuButtonId { get; set; }
        [ForeignKey(nameof(PersonnelClassDtId))]
        public Guid PersonnelClassDtId { get; set; }
        public virtual PersonnelClass PersonnelClass { get; set; }
    }
}
