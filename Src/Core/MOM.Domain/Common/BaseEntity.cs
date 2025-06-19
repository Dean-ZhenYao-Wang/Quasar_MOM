using System.ComponentModel.DataAnnotations;

namespace MOM.Domain.Common
{
    /// <summary>
    /// 模型的抽象基类
    /// </summary>
    public abstract class BaseEntity
    {
        /// <summary>
        /// 数据库唯一主键
        /// </summary>
        [Key]
        public Guid DtId { get; set; } = Guid.NewGuid();

        /// <summary>
        /// 编号
        /// 对象ID仅仅用于在相关的交换信息集中确认该对象。对象ID属性不是全局的对象ID，也不是数据库索引属性。
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
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
        /// 软删除
        /// </summary>
        public virtual void Delete()
        {
            this.IsDelete = true;
        }
    }
}