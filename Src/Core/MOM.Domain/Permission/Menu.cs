using MOM.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace MOM.Domain.Permission
{
    /// <summary>
    /// 菜单
    /// </summary>
    public class Menu : BaseEntity
    {
        /// <summary>
        /// 前端路径
        /// </summary>
        public string Path { get; set; } = string.Empty;

        /// <summary>
        /// 说明
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// 图标
        /// </summary>
        public string? Icon { get; set; }

        /// <summary>
        /// 是否隐藏菜单
        /// </summary>
        public bool Hidden { get; set; }

        /// <summary>
        /// 是否总是显示
        /// </summary>
        public bool AlwaysShow { get; set; }

        /// <summary>
        /// 子级菜单列表
        /// </summary>
        public virtual List<Menu> Children { get; set; } = new();

        /// <summary>
        /// 当前页面拥有的按钮清单
        /// </summary>
        public virtual List<Button> Buttons { get; set; } = new();

        /// <summary>
        /// 第几层的菜单
        /// </summary>
        public int Depth { get; set; }

        /// <summary>
        /// 父级菜单的主键
        /// </summary>
        public Guid? ParentMenuDtId { get; set; }

        /// <summary>
        /// 父级菜单
        /// </summary>
        [ForeignKey(nameof(ParentMenuDtId))]
        public virtual Menu? ParentMenu { get; set; }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="id">编号</param>
        /// <param name="name">名称</param>
        /// <param name="path">前端路径</param>
        /// <param name="description">说明</param>
        /// <param name="icon">图标</param>
        /// <param name="hidden">是否隐藏菜单</param>
        /// <param name="alwaysShow">是否总是显示</param>
        /// <param name="depth">第几层的菜单</param>
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