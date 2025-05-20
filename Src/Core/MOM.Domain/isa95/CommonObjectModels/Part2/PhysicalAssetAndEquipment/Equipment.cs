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
        /// �����豸���嵥
        /// </summary>
        [JsonIgnore]
        public virtual EquipmentDefinedByRelationshipCollection DefinedBy { get; set; } = new EquipmentDefinedByRelationshipCollection();

        /// <summary>
        /// �Զ��������嵥
        /// </summary>
        [JsonIgnore]
        public virtual EquipmentHasValuesOfRelationshipCollection HasValuesOf { get; set; } = new EquipmentHasValuesOfRelationshipCollection();

        /// <summary>
        /// ������豸�����豸�����塣<br/>
        /// ��ɹ�ϵ
        /// </summary>
        [JsonIgnore]
        public virtual EquipmentIsMadeUpOfRelationshipCollection IsMadeUpOf { get; set; } = new EquipmentIsMadeUpOfRelationshipCollection();

        /// <summary>
        /// ��Ӧ��ʵ���ʲ�<br/>
        /// ���豸�ڹ��ն��е���������ʵ���ʲ�ʵ�ֵġ�
        /// </summary>
        [JsonIgnore]
        [MaxLength(1)]
        public virtual EquipmentImplementedByRelationshipCollection ImplementedBy { get; set; } = new EquipmentImplementedByRelationshipCollection();

        [JsonIgnore]
        [MaxLength(1)]
        public virtual EquipmentHierarchyScopeRelRelationshipCollection HierarchyScopeRel { get; set; } = new EquipmentHierarchyScopeRelRelationshipCollection();

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