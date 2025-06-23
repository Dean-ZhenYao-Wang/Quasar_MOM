using MOM.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace MOM.Domain.Permission
{
    /// <summary>
    /// 按钮
    /// </summary>
    public class Button : BaseEntity
    {
        /// <summary>
        /// 图标
        /// </summary>
        public string? Icon { get; set; }

        /// <summary>
        /// 关联的菜单主键
        /// </summary>
        public Guid MenuDtId { get; set; }

        [ForeignKey(nameof(MenuDtId))]
        public virtual Menu Menu { get; set; }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="id">编号</param>
        /// <param name="name">名称</param>
        /// <param name="icon">图标</param>
        public void Update(string id, string name, string? icon)
        {
            this.Id = id;
            this.Name = name;
            this.Icon = icon;
        }
    }
}