using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Application.DTOs.Common
{
    public class TreeNode<TEntity>
    {
        /// <summary>
        /// 节点的强制唯一键
        /// </summary>
        public string key { get; set; } = string.Empty;
        /// <summary>
        /// 节点的标签
        /// </summary>
        public string label { get; set; } = string.Empty;
        /// <summary>
        /// 节点表示的数据
        /// </summary>
        public TEntity data { get; set; } = default!;
        /// <summary>
        /// 要匹配模板的节点类型
        /// </summary>
        public string type { get; set; } = string.Empty;
        /// <summary>
        /// 要在内容旁边显示的节点的图标
        /// </summary>
        public string icon { get; set; } = string.Empty;
        /// <summary>
        /// 作为子项的 treenodes 数组
        /// </summary>
        public List<TreeNode<TEntity>> children { get; set; } = new List<TreeNode<TEntity>>();
        /// <summary>
        /// 启用选择模式时节点是否可选
        /// </summary>
        public bool selectable { get; set; } = true;
        /// <summary>
        /// 指定节点是否具有子项。用于延迟加载。若为true时，前端控件则是看children是否含有元素，如果有则会显示折叠图标，否则不显示
        /// </summary>
        public bool leaf { get; set; } = true;
        /// <summary>
        /// 指定节点加载。用于 Tree 和 TreeTable
        /// </summary>
        public bool loading { get; set; }
    }
}
