namespace MOM.Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.EquipmentAssetMapping;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Text.Json.Serialization;
    /// <summary>
    /// 设备资产映射
    /// </summary>
    /// <remarks>
    /// <para>物理资产与设备之间的关系应表示为设备资产映射</para>
    /// <para>该映射记录设备对象与物理资产对象关联的时间段</para>
    /// </remarks>
    public class EquipmentAssetMapping : BaseEntity, IEquatable<EquipmentAssetMapping>
    {
        /// <summary>
        /// 执行制造功能的设备
        /// </summary>
        /// <remarks>
        /// 记录使用的
        /// </remarks>
        [JsonIgnore]
        public virtual EquipmentAssetMappingRecordsUseOfEquipmentRelationship RecordsUseOfEquipment { get; set; }
        /// <summary>
        /// 与设备关联的物理资产（当物理资产与制造功能相关时）
        /// </summary>
        /// <remarks>
        /// 记录使用的
        /// </remarks>
        [JsonIgnore]
        public virtual EquipmentAssetMappingRecordsUseOfPhysicalAssetRelationship RecordsUseOfPhysicalAsset { get; set; }
        /// <summary>
        /// 映射元素的补充信息
        /// </summary>
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
        /// 起始时间
        /// </summary>
        /// <remarks>
        /// 关联关系的开始时间
        /// </remarks>
        public DateTime? StartTime { get; set; }
        /// <summary>
        /// 结束时间
        /// </summary>
        /// <remarks>
        /// 关联关系的结束时间
        /// </remarks>
        public DateTime? EndTime { get; set; }

        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentAssetMapping);
        }

        /// <inheritdoc/>
        public bool Equals(EquipmentAssetMapping? other)
        {
            return other is not null && base.Equals(other) && HierarchyScope == other.HierarchyScope && StartTime == other.StartTime && EndTime == other.EndTime;
        }

        /// <inheritdoc/>
        public static bool operator ==(EquipmentAssetMapping? left, EquipmentAssetMapping? right)
        {
            return EqualityComparer<EquipmentAssetMapping?>.Default.Equals(left, right);
        }

        /// <inheritdoc/>
        public static bool operator !=(EquipmentAssetMapping? left, EquipmentAssetMapping? right)
        {
            return !(left == right);
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), HierarchyScope?.GetHashCode(), StartTime?.GetHashCode(), EndTime?.GetHashCode());
        }
    }
}