namespace MOM.Domain.isa95.CommonObjectModels.Part2.ProcessSegment
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.EquipmentSegmentSpecification;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class EquipmentSegmentSpecification : BaseEntity, IEquatable<EquipmentSegmentSpecification>
    {
        public EquipmentSegmentSpecification()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:EquipmentSegmentSpecification;1";

        [JsonPropertyName("hierarchyScope")]
        public string? HierarchyScope { get; set; }

        [JsonPropertyName("operationalLocation")]
        public string? OperationalLocation { get; set; }

        [JsonPropertyName("operationalLocationType")]
        public EquipmentSegmentSpecificationOperationalLocationType? OperationalLocationType { get; set; }

        [JsonPropertyName("equipmentUse")]
        public string? EquipmentUse { get; set; }

        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        [JsonPropertyName("quantityUnitOfMeasure")]
        public string? QuantityUnitOfMeasure { get; set; }

        [JsonIgnore]
public virtual List<EquipmentSegmentSpecificationIsMadeUpOfRelationship> IsMadeUpOf { get; set; } = new List<EquipmentSegmentSpecificationIsMadeUpOfRelationship>();

        [JsonIgnore]
public virtual List<EquipmentSegmentSpecificationSpecifiesRelationship> Specifies { get; set; } = new List<EquipmentSegmentSpecificationSpecifiesRelationship>();

        [JsonIgnore]
public virtual List<EquipmentSegmentSpecificationHasPropertiesOfRelationship> HasPropertiesOf { get; set; } = new List<EquipmentSegmentSpecificationHasPropertiesOfRelationship>();

        [JsonIgnore]
public virtual List<EquipmentSegmentSpecificationCorrespondsToEquipmentClassRelationship> CorrespondsToEquipmentClass { get; set; } = new List<EquipmentSegmentSpecificationCorrespondsToEquipmentClassRelationship>();

        [JsonIgnore]
public virtual List<EquipmentSegmentSpecificationCorrespondsToEquipmentRelationship> CorrespondsToEquipment { get; set; } = new List<EquipmentSegmentSpecificationCorrespondsToEquipmentRelationship>();

        [JsonIgnore]
public virtual List<EquipmentSegmentSpecificationHierarchyScopeRelRelationship> HierarchyScopeRel { get; set; } = new List<EquipmentSegmentSpecificationHierarchyScopeRelRelationship>();

        [JsonIgnore]
public virtual List<EquipmentSegmentSpecificationOperationalLocationRelRelationship> OperationalLocationRel { get; set; } = new List<EquipmentSegmentSpecificationOperationalLocationRelRelationship>();

        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentSegmentSpecification);
        }

        public bool Equals(EquipmentSegmentSpecification? other)
        {
            return other is not null && base.Equals(other) && HierarchyScope == other.HierarchyScope && OperationalLocation == other.OperationalLocation && OperationalLocationType == other.OperationalLocationType && EquipmentUse == other.EquipmentUse && Quantity == other.Quantity && QuantityUnitOfMeasure == other.QuantityUnitOfMeasure;
        }

        public static bool operator ==(EquipmentSegmentSpecification? left, EquipmentSegmentSpecification? right)
        {
            return EqualityComparer<EquipmentSegmentSpecification?>.Default.Equals(left, right);
        }

        public static bool operator !=(EquipmentSegmentSpecification? left, EquipmentSegmentSpecification? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), HierarchyScope?.GetHashCode(), OperationalLocation?.GetHashCode(), OperationalLocationType?.GetHashCode(), EquipmentUse?.GetHashCode(), Quantity?.GetHashCode(), QuantityUnitOfMeasure?.GetHashCode());
        }
    }
}