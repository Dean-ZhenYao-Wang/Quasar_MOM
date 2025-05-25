using MOM.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace MOM.Domain.Permission
{
    public class Menu : BaseEntity
    {
        public string Name { get; set; }
        public string Path { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string? Icon { get; set; }

        /// <summary>
        /// 是否隐藏菜单
        /// </summary>
        public bool Hidden { get; set; }

        /// <summary>
        /// 是否总是显示
        /// </summary>
        public bool AlwaysShow { get; set; }

        public virtual List<Menu> Children { get; set; } = new();
        public virtual List<Button> Buttons { get; set; } = new();

        /// <summary>
        /// 第几层的菜单
        /// </summary>
        public int Depth { get; set; }

        [ForeignKey(nameof(ParentMenuDtId))]
        public Guid? ParentMenuDtId { get; set; }

        public virtual Menu? ParentMenu { get; set; }

        public void Update(string id, string name, string path, string? description, string? icon, bool hidden, bool alwaysShow, int depth)
        {
            this.Id = id;
            this.Name = name;
            this.Path = path;
            this.Description = description;
            this.Icon = icon;
            this.Hidden = hidden;
            this.AlwaysShow = alwaysShow;
            this.Depth = depth;
        }
    }
}