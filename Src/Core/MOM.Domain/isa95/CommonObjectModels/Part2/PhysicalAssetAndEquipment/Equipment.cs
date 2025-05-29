namespace MOM.Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.Equipment;
    using MOM.Domain.isa95.CommonObjectModels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text.Json.Serialization;

    public partial class Equipment : Resource, IEquatable<Equipment>
    {
        public Equipment()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:Equipment;1";

        [JsonPropertyName("hierarchyScope")]
        public string HierarchyScope
        {
            get { return HierarchyScopeRel.FirstOrDefault() == null ? string.Empty : HierarchyScopeRel.FirstOrDefault().Target.Id; }
        }

        [JsonPropertyName("equipmentLevel")]
        public EquipmentEquipmentLevel? EquipmentLevel { get; set; }

        /// <summary>
        /// 所属设备类清单
        /// </summary>
        [JsonIgnore]
public virtual List<EquipmentDefinedByRelationship> DefinedBy { get; set; } = new List<EquipmentDefinedByRelationship>();

        /// <summary>
        /// 自定义属性清单
        /// </summary>
        [JsonIgnore]
public virtual List<EquipmentHasValuesOfRelationship> HasValuesOf { get; set; } = new List<EquipmentHasValuesOfRelationship>();

        /// <summary>
        /// 这个父设备是子设备的整体。<br/>
        /// 组成关系
        /// </summary>
        [JsonIgnore]
public virtual List<EquipmentIsMadeUpOfRelationship> IsMadeUpOf { get; set; } = new List<EquipmentIsMadeUpOfRelationship>();

        /// <summary>
        /// 对应的实物资产<br/>
        /// 该设备在工艺段中的作用是由实物资产实现的。
        /// </summary>
        [JsonIgnore]
        [MaxLength(1)]
public virtual List<EquipmentImplementedByRelationship> ImplementedBy { get; set; } = new List<EquipmentImplementedByRelationship>();

        [JsonIgnore]
        [MaxLength(1)]
public virtual List<EquipmentHierarchyScopeRelRelationship> HierarchyScopeRel { get; set; } = new List<EquipmentHierarchyScopeRelRelationship>();

        public override bool Equals(object? obj)
        {
            return Equals(obj as Equipment);
        }

        public bool Equals(Equipment? other)
        {
            return other is not null && base.Equals(other) && HierarchyScope == other.HierarchyScope && EquipmentLevel == other.EquipmentLevel;
        }

        public static bool operator ==(Equipment? left, Equipment? right)
        {
            return EqualityComparer<Equipment?>.Default.Equals(left, right);
        }

        public static bool operator !=(Equipment? left, Equipment? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), HierarchyScope?.GetHashCode(), EquipmentLevel?.GetHashCode());
        }

        public void HasValuesOfAddTarget(EquipmentProperty equipmentProperty)
        {
            this.HasValuesOf.Add(new EquipmentHasValuesOfRelationship(this, equipmentProperty));
        }
    }
}