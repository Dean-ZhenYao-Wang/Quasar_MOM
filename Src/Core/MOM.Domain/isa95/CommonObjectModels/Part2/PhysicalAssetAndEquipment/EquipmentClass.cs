namespace MOM.Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.EquipmentClass;
    using MOM.Domain.isa95.CommonObjectModels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text.Json.Serialization;

    public partial class EquipmentClass : ResourceClass, IEquatable<EquipmentClass>
    {
        public EquipmentClass()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:EquipmentClass;1";

        [JsonPropertyName("hierarchyScope")]
        public string HierarchyScope => HierarchyScopeRel.FirstOrDefault() == null ? string.Empty : HierarchyScopeRel.FirstOrDefault().Target.Id;

        /// <summary>
        /// 在基于角色的装备层次中级别的标识
        /// </summary>
        [JsonPropertyName("equipmentLevel")]
        public EquipmentClassEquipmentLevel? EquipmentLevel { get; set; }

        /// <summary>
        /// 当前分类包含的子分类。<br/>
        /// 父子关系（主要类别，如生产类、一起类、辅助类、工具类、运输类、管理类等）<br/>
        /// 设备->主要设备->甲类设备<br/>
        /// 设备->主要设备->乙类设备<br/>
        /// 设备->产线->罐装产线
        /// </summary>
        [JsonIgnore]
        public virtual EquipmentClassIncludesPropertiesOfRelationshipCollection IncludesPropertiesOf { get; set; } = new EquipmentClassIncludesPropertiesOfRelationshipCollection();

        /// <summary>
        /// 这个父设备类是子设备类的整体。<br/>
        /// 组成关系（具体的设备类别，如反应器、压缩机、CNC、叉车、行车等）<br/>
        /// 罐装产线->A类设备<br/>
        /// 罐装产线->B类设备<br/>
        /// A类设备与B类设备共同组成罐装产线
        /// </summary>
        [JsonIgnore]
        public virtual EquipmentClassIsMadeUpOfRelationshipCollection IsMadeUpOf { get; set; } = new EquipmentClassIsMadeUpOfRelationshipCollection();

        /// <summary>
        /// 自定义属性清单
        /// </summary>
        [JsonIgnore]
        public virtual EquipmentClassHasPropertiesOfRelationshipCollection HasPropertiesOf { get; set; } = new EquipmentClassHasPropertiesOfRelationshipCollection();

        [JsonIgnore]
        [MaxLength(1)]
        public virtual EquipmentClassHierarchyScopeRelRelationshipCollection HierarchyScopeRel { get; set; } = new EquipmentClassHierarchyScopeRelRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentClass);
        }

        public bool Equals(EquipmentClass? other)
        {
            return other is not null && base.Equals(other) && HierarchyScope == other.HierarchyScope && EquipmentLevel == other.EquipmentLevel;
        }

        public static bool operator ==(EquipmentClass? left, EquipmentClass? right)
        {
            return EqualityComparer<EquipmentClass?>.Default.Equals(left, right);
        }

        public static bool operator !=(EquipmentClass? left, EquipmentClass? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), HierarchyScope?.GetHashCode(), EquipmentLevel?.GetHashCode());
        }
    }
}