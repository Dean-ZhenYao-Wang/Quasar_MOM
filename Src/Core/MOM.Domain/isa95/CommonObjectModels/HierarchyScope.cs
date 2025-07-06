namespace MOM.Domain.isa95.CommonObjectModels
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.HierarchyScope;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text.Json.Serialization;

    /// <summary>
    /// 层次范围
    /// </summary>
    /// <remarks>
    /// 层次范围标识交换信息在基于角色的设备层次结构中的位置。它定义交换信息的范围（如ISA-95标准中的站点或区域），并标识角色设备层次中的关联实例。
    /// </remarks>
    public partial class HierarchyScope : IEquatable<MOM.Domain.isa95.CommonObjectModels.HierarchyScope>
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
        /// 设备ID
        /// </summary>
        public string? EquipmentID { get; set; }

        /// <summary>
        /// 设备层级
        /// </summary>
        /// <remarks>
        /// 基于角色的设备层次结构中的层级标识
        /// </remarks>
        public HierarchyScopeEquipmentLevel EquipmentLevel { get; set; }

        /// <summary>
        /// 包含的子级
        /// </summary>
        [JsonIgnore]
        public virtual List<HierarchyScopeContainsRelationship> Contains { get; set; } = new List<HierarchyScopeContainsRelationship>();

        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            return Equals(obj as HierarchyScope);
        }

        /// <inheritdoc/>
        public bool Equals(HierarchyScope? other)
        {
            return other is not null && base.Equals(other) && EquipmentID == other.EquipmentID && EquipmentLevel == other.EquipmentLevel;
        }

        /// <inheritdoc/>
        public static bool operator ==(HierarchyScope? left, HierarchyScope? right)
        {
            return EqualityComparer<HierarchyScope?>.Default.Equals(left, right);
        }

        /// <inheritdoc/>
        public static bool operator !=(HierarchyScope? left, HierarchyScope? right)
        {
            return !(left == right);
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), EquipmentID?.GetHashCode(), EquipmentLevel.GetHashCode());
        }
    }
}