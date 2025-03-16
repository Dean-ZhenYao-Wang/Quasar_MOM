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
        public virtual EquipmentSegmentSpecificationIsMadeUpOfRelationshipCollection IsMadeUpOf { get; set; } = new EquipmentSegmentSpecificationIsMadeUpOfRelationshipCollection();

        [JsonIgnore]
        public virtual EquipmentSegmentSpecificationSpecifiesRelationshipCollection Specifies { get; set; } = new EquipmentSegmentSpecificationSpecifiesRelationshipCollection();

        [JsonIgnore]
        public virtual EquipmentSegmentSpecificationHasPropertiesOfRelationshipCollection HasPropertiesOf { get; set; } = new EquipmentSegmentSpecificationHasPropertiesOfRelationshipCollection();

        [JsonIgnore]
        public virtual EquipmentSegmentSpecificationCorrespondsToEquipmentClassRelationshipCollection CorrespondsToEquipmentClass { get; set; } = new EquipmentSegmentSpecificationCorrespondsToEquipmentClassRelationshipCollection();

        [JsonIgnore]
        public virtual EquipmentSegmentSpecificationCorrespondsToEquipmentRelationshipCollection CorrespondsToEquipment { get; set; } = new EquipmentSegmentSpecificationCorrespondsToEquipmentRelationshipCollection();

        [JsonIgnore]
        public virtual EquipmentSegmentSpecificationHierarchyScopeRelRelationshipCollection HierarchyScopeRel { get; set; } = new EquipmentSegmentSpecificationHierarchyScopeRelRelationshipCollection();

        [JsonIgnore]
        public virtual EquipmentSegmentSpecificationOperationalLocationRelRelationshipCollection OperationalLocationRel { get; set; } = new EquipmentSegmentSpecificationOperationalLocationRelRelationshipCollection();

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