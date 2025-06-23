namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationalLocation
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.OperationalLocation;
    using MOM.Domain.isa95.CommonObjectModels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Text.Json.Serialization;

    /// <summary>
    /// 操作位置
    /// </summary>
    /// <remarks>
    /// <para>物料批次、物料子批次、设备、物理资产或人员所处或预期所处的逻辑或物理位置应表示为操作位置。</para>
    /// <para>操作位置可由其他操作位置组成</para>
    /// </remarks>
    public class OperationalLocation : Resource, IEquatable<OperationalLocation>
    {
        /// <summary>
        /// 此操作位置所属的操作位置类别
        /// </summary>
        /// <remarks>
        /// 关系类型：关联
        /// </remarks>
        [JsonIgnore]
        public virtual List<OperationalLocationDefinedByRelationship> DefinedBy { get; set; } = new List<OperationalLocationDefinedByRelationship>();

        /// <summary>
        /// 此操作位置的属性值
        /// </summary>
        [JsonIgnore]
        public virtual OperationalLocationProperty HasValuesOf { get; set; }

        /// <summary>
        /// 由...组成
        /// </summary>
        /// <remarks>
        /// 包含在此操作位置中的子操作位置
        /// </remarks>
        [JsonIgnore]
        public virtual List<OperationalLocationIsMadeUpOfRelationship> IsMadeUpOf { get; set; } = new List<OperationalLocationIsMadeUpOfRelationship>();

        /// <summary>
        /// 描述
        /// </summary>
        /// <remarks>
        /// 包含操作位置的补充信息和描述
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

        /// <summary>
        /// 在空间上将设备定义为零维点、一维线、二维形状或三维实体。
        /// </summary>
        [JsonIgnore]
        public SpatialDefinition SpatialDefinition { get; set; }

        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationalLocation);
        }

        /// <inheritdoc/>
        public bool Equals(OperationalLocation? other)
        {
            return other is not null && base.Equals(other) && HierarchyScope == other.HierarchyScope;
        }

        /// <inheritdoc/>
        public static bool operator ==(OperationalLocation? left, OperationalLocation? right)
        {
            return EqualityComparer<OperationalLocation?>.Default.Equals(left, right);
        }

        /// <inheritdoc/>
        public static bool operator !=(OperationalLocation? left, OperationalLocation? right)
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