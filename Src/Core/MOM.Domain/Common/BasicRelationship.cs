using System.ComponentModel.DataAnnotations;

namespace MOM.Domain.Common
{
    /// <summary>
    /// 虽然关系可以自定义架构，但所有关系实例都应包含以下基础属性。该基类可确保自定义关系具备必要的基础属性。
    /// </summary>
    public abstract class BasicRelationship
    {
        /// <summary>
        /// 数据库唯一主键
        /// </summary>
        [Key]
        public Guid DtId { get; set; } = Guid.NewGuid();

        /// <summary>
        /// 对象ID仅仅用于在相关的交换信息集中确认该对象。对象ID属性不是全局的对象ID，也不是数据库索引属性。
        /// <para>由SourceID-TargetId拼接而成</para>
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// 创建者数据库唯一标识
        /// </summary>
        public Guid CreatedBy { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// 最后修改者数据库唯一标识
        /// </summary>
        public Guid? LastModifiedBy { get; set; }

        /// <summary>
        /// 最后修改时间
        /// </summary>
        public DateTime? LastModified { get; set; }

        /// <summary>
        /// 是否删除
        /// </summary>
        public bool IsDelete { get; set; }

        /// <summary>
        /// 目标数字孪生的唯一标识符。该属性存在于所有关系中。
        /// </summary>
        public Guid TargetId { get; set; }

        /// <summary>
        /// 源数字孪生的唯一标识符。该属性存在于所有关系中。
        /// </summary>
        public Guid SourceId { get; set; }

        /// <summary>
        /// 关系名称，定义链接类型（例如"contains"）。该属性存在于所有关系中。
        /// </summary>
        public abstract string Name { get; set; }

        /// <summary>
        /// 深度
        /// </summary>
        public int Depth { get; set; }
    }
}