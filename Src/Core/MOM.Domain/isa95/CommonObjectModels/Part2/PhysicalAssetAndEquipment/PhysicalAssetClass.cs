namespace MOM.Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.PhysicalAssetClass;
    using MOM.Domain.isa95.CommonObjectModels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Text.Json.Serialization;

    /// <summary>
    /// 物理资产类
    /// </summary>
    /// <remarks>
    /// <para>物理资产类表示具有相似特征的物理资产分组，用于维修和替换目的。</para>
    /// <para>任何物理资产都属于一个物理资产类。</para>
    /// <para>物理资产类可定义为零个或多个物理资产类的特化，也可由零个或多个物理资产类组成。</para>
    /// </remarks>
    public partial class PhysicalAssetClass : ResourceClass, IEquatable<PhysicalAssetClass>
    {
        private PhysicalAssetClass() { }
        /// <summary>
        /// 物理资产制造商的唯一标识符
        /// </summary>
        public string? Manufacturer { get; set; }

        /// <summary>
        /// 表示当前物理资产类包含其他物理资产类的属性（属性继承）(包含关系)
        /// </summary>
        [JsonIgnore]
        public virtual List<PhysicalAssetClassIncludesPropertiesOfRelationship> IncludesPropertiesOf { get; set; } = new List<PhysicalAssetClassIncludesPropertiesOfRelationship>();

        /// <summary>
        /// 表示父物理资产类由子物理资产类作为组成部分（组合关系）
        /// </summary>
        [JsonIgnore]
        public virtual List<PhysicalAssetClassIsMadeUpOfRelationship> IsMadeUpOf { get; set; } = new List<PhysicalAssetClassIsMadeUpOfRelationship>();

        /// <summary>
        /// 扩展属性
        /// </summary>
        public virtual PhysicalAssetClassProperty Property { get; set; } = new PhysicalAssetClassProperty();

        /// <summary>
        /// 物理资产类的附加描述信息
        /// </summary>
        public string Description { get; private set; }

        /// <summary>
        /// 标识在基于角色的设备层次结构中的位置
        /// </summary>
        public Guid? HierarchyScopeRelDtId { get; set; }

        /// <summary>
        /// 标识在基于角色的设备层次结构中的位置
        /// </summary>
        public string? HierarchyScope
        { get { return HierarchyScopeRel?.FullPath; } }

        /// <summary>
        /// 关联物理资产类在设备层次结构中的具体范围定义
        /// </summary>
        [ForeignKey(nameof(HierarchyScopeRelDtId))]
        [JsonIgnore]
        public virtual HierarchyScope HierarchyScopeRel { get; set; }

        public PhysicalAssetClass(string ID, string description = "", string manufacturer = "", Guid? hierarchyScopeDtId = null)
        {
            this.Id = Id;
            this.Description = description;
            this.Manufacturer = manufacturer;
            this.HierarchyScopeRelDtId = hierarchyScopeDtId;
        }

        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            return Equals(obj as PhysicalAssetClass);
        }

        /// <inheritdoc/>
        public bool Equals(PhysicalAssetClass? other)
        {
            return other is not null && base.Equals(other) && Manufacturer == other.Manufacturer && HierarchyScope == other.HierarchyScope;
        }

        /// <inheritdoc/>
        public static bool operator ==(PhysicalAssetClass? left, PhysicalAssetClass? right)
        {
            return EqualityComparer<PhysicalAssetClass?>.Default.Equals(left, right);
        }

        /// <inheritdoc/>
        public static bool operator !=(PhysicalAssetClass? left, PhysicalAssetClass? right)
        {
            return !(left == right);
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Manufacturer?.GetHashCode(), HierarchyScope?.GetHashCode());
        }

        /// <inheritdoc/>
        public override void Delete()
        {
            this.IsDelete = true;
        }
    }
}