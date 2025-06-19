namespace MOM.Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.PhysicalAsset;
    using MOM.Domain.isa95.CommonObjectModels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Text.Json.Serialization;
    /// <summary>
    /// 物理资产
    /// </summary>
    /// <remarks>
    /// 物理设备应表示为物理资产
    /// </remarks>
    public class PhysicalAsset : Resource, IEquatable<PhysicalAsset>
    {
        /// <summary>
        /// 固定资产ID
        /// </summary>
        /// <remarks>
        /// 包含法律或法规要求的财务追踪唯一标识
        /// </remarks>
        public required string FixedAssetID { get; set; }
        /// <summary>
        /// 供应商ID
        /// </summary>
        /// <remarks>
        /// 包含供应商序列号
        /// </remarks>
        public string? VendorID { get; set; }
        /// <summary>
        /// 空间定义
        /// </summary>
        /// <remarks>
        /// 将物理资产在空间上定义为零维点、一维线、二维面或三维体
        /// </remarks>
        public SpatialDefinition SpatialDefinition { get; set; }
        /// <summary>
        /// 由...定义
        /// </summary>
        /// <remarks>
        /// 此物理资产支持的物理资产类别。该物理资产支持与物理资产类别关联的属性
        /// <para>关系类型：关联</para>
        /// </remarks>
        [JsonIgnore]
        public virtual List<PhysicalAssetDefinedByRelationship> DefinedBy { get; set; } = new List<PhysicalAssetDefinedByRelationship>();
        /// <summary>
        /// 此物理资产的属性值
        /// </summary>
        public virtual PhysicalAssetProperty Property { get; set; } = new PhysicalAssetProperty();
        /// <summary>
        /// 由...组成
        /// </summary>
        /// <remarks>
        /// 相关对象作为整体构成此物理资产的一部分
        /// </remarks>
        [JsonIgnore]
        public virtual List<PhysicalAssetIsMadeUpOfRelationship> IsMadeUpOf { get; set; } = new List<PhysicalAssetIsMadeUpOfRelationship>();
        /// <summary>
        /// 描述
        /// </summary>
        /// <remarks>
        /// 物理资产的补充信息
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
        /// 物理位置
        /// </summary>
        /// <remarks>
        /// 包含物理位置信息（如地址或坐标）
        /// </remarks>
        public string PhysicalLocation { get; set; }
        /// <summary>
        /// 适配物理位置
        /// </summary>
        /// <remarks>
        /// <para>与物理位置的可选关系</para>
        /// <para>非标准规范要求</para>
        /// </remarks>
        [JsonIgnore]
        public virtual Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation PhysicalLocationRel { get; set; }
        /// <summary>
        /// 物理位置类型
        /// </summary>
        /// <remarks>
        /// 标识物理位置属性引用的是操作位置对象还是包含位置描述
        /// </remarks>
        public PhysicalAssetPhysicalLocationType PhysicalLocationType { get; set; }

        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            return Equals(obj as PhysicalAsset);
        }

        /// <inheritdoc/>
        public bool Equals(PhysicalAsset? other)
        {
            return other is not null && base.Equals(other) && HierarchyScope == other.HierarchyScope && FixedAssetID == other.FixedAssetID && VendorID == other.VendorID && PhysicalLocation == other.PhysicalLocation && PhysicalLocationType == other.PhysicalLocationType;
        }

        /// <inheritdoc/>
        public static bool operator ==(PhysicalAsset? left, PhysicalAsset? right)
        {
            return EqualityComparer<PhysicalAsset?>.Default.Equals(left, right);
        }

        /// <inheritdoc/>
        public static bool operator !=(PhysicalAsset? left, PhysicalAsset? right)
        {
            return !(left == right);
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), HierarchyScope?.GetHashCode(), FixedAssetID?.GetHashCode(), VendorID?.GetHashCode(), PhysicalLocation?.GetHashCode(), PhysicalLocationType.GetHashCode());
        }
    }
}