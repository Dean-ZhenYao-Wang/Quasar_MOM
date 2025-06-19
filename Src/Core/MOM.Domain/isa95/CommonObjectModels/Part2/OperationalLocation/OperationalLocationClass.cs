namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationalLocation
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.OperationalLocationClass;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Text.Json.Serialization;
    /// <summary>
    /// 操作位置类别
    /// </summary>
    /// <remarks>
    /// <para>表示具有相似特性的操作位置分组，用于特定目的（如制造运营定义、调度、能力和性能），应表示为操作位置类别。</para>
    /// <para>任何操作位置可以是零个或多个操作位置类别的成员</para>
    /// </remarks>
    public class OperationalLocationClass : BaseEntity, IEquatable<OperationalLocationClass>
    {
        /// <summary>
        /// 包含...的属性
        /// </summary>
        /// <remarks>
        /// 此操作位置类别包含目标操作位置类别的属性
        /// </remarks>
        [JsonIgnore]
        public virtual List<OperationalLocationClassIncludesPropertiesOfRelationship> IncludesPropertiesOf { get; set; } = new List<OperationalLocationClassIncludesPropertiesOfRelationship>();
        /// <summary>
        /// 由...组成
        /// </summary>
        /// <remarks>
        /// 此父操作位置类别作为整体，由子操作位置类别作为组成部分
        /// </remarks>
        [JsonIgnore]
        public virtual List<OperationalLocationClassIsMadeUpOfRelationship> IsMadeUpOf { get; set; } = new List<OperationalLocationClassIsMadeUpOfRelationship>();
        /// <summary>
        /// 此操作位置类别具有的属性
        /// </summary>
        public OperationalLocationClassProperty Property { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        /// <remarks>
        /// 操作位置类别的补充信息
        /// </remarks>
        public string? Description { get; set; }


        /// <summary>
        /// 层级范围
        /// </summary>
        /// <remarks>
        /// 标识交换信息在基于角色的设备层级中的位置。可选地，层级范围可定义物理资产类别的范围（如定义的站点或区域）
        /// <para>与层级的可选关系</para>
        /// <para>非标准规范要求</para>
        /// </remarks>
        public Guid? HierarchyScopeRelDtId { get; set; }
        /// <summary>
        /// 层级范围
        /// </summary>
        /// <remarks>
        /// 标识交换信息在基于角色的设备层级中的位置。可选地，层级范围可定义物理资产类别的范围（如定义的站点或区域）
        /// <para>与层级的可选关系</para>
        /// <para>非标准规范要求</para>
        /// </remarks>
        public string? HierarchyScope
        { get { return HierarchyScopeRel?.FullPath; } }
        /// <summary>
        /// 适配层级范围
        /// </summary>
        /// <remarks>
        /// <para>与层级的可选关系</para>
        /// <para>非标准规范要求</para>
        /// </remarks>
        [ForeignKey(nameof(HierarchyScopeRelDtId))]
        [JsonIgnore]
        public virtual HierarchyScope HierarchyScopeRel { get; set; }

        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationalLocationClass);
        }

        /// <inheritdoc/>
        public bool Equals(OperationalLocationClass? other)
        {
            return other is not null && base.Equals(other) && HierarchyScope == other.HierarchyScope;
        }

        /// <inheritdoc/>
        public static bool operator ==(OperationalLocationClass? left, OperationalLocationClass? right)
        {
            return EqualityComparer<OperationalLocationClass?>.Default.Equals(left, right);
        }

        /// <inheritdoc/>
        public static bool operator !=(OperationalLocationClass? left, OperationalLocationClass? right)
        {
            return !(left == right);
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), HierarchyScope?.GetHashCode());
        }
    }
}