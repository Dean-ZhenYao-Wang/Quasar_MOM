using MOM.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace MOM.Domain.Permission
{
    public class Button : BaseEntity
    {
        public string Name { get; set; }
        public string? Icon { get; set; }

        [ForeignKey(nameof(MenuDtId))]
        public Guid MenuDtId { get; set; }

        public virtual Menu Menu { get; set; }

        public void Update(string id, string name, string? icon)
        {
            this.Id = id;
            this.Name = name;
            this.Icon = icon;
        }
    }
}