using MOM.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace MOM.Domain.Permission
{
    public class Button : BaseEntity
    {
        public required string Name { get; set; }
        public string? Icon { get; set; }
        [ForeignKey(nameof(MenuDtId))]
        public required Guid MenuDtId { get; set; }
        public virtual Menu Menu { get; set; }
    }
}
