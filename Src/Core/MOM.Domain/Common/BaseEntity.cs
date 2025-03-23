using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MOM.Domain.Common
{
    public abstract class BaseEntity
    {
        [Key]
        public Guid DtId { get; set; } = Guid.NewGuid();
        /// <summary>
        /// 名称
        /// 对象ID仅仅用于在相关的交换信息集中确认该对象。对象ID属性不是全局的对象ID，也不是数据库索引属性。
        /// </summary>
        [JsonPropertyName("Id")]
        public string Id { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime Created { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public DateTime? LastModified { get; set; }
        public bool IsDelete { get; set; }
    }
}
