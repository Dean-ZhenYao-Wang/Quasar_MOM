namespace MOM.Domain.isa95.CommonObjectModels
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.HierarchyScope;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    /// <summary>
    /// 层次范围
    /// </summary>
    /// <remarks>
    /// 层次范围标识交换信息在基于角色的设备层次结构中的位置。它定义交换信息的范围（如ISA-95标准中的站点或区域），并标识角色设备层次中的关联实例。
    /// </remarks>
    public partial class HierarchyScope : BaseEntity, IEquatable<MOM.Domain.isa95.CommonObjectModels.HierarchyScope>
    {
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