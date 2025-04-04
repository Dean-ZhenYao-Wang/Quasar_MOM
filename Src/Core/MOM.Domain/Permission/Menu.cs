using MOM.Domain.Common;

namespace MOM.Domain.Permission
{
    public class Menu : BaseEntity
    {
        public required string Name { get; set; }
        public required string Path { get; set; }
        public string Component { get; set; }
        public string Icon { get; set; }
        public bool Hidden { get; set; }
        public bool AlwaysShow { get; set; }
        public List<Menu> Children { get; set; } = new();
        public List<Button> Buttons { get; set; } = new();
        /// <summary>
        /// 第几层的菜单
        /// </summary>
        public int Depth { get; set; }
    }
}
