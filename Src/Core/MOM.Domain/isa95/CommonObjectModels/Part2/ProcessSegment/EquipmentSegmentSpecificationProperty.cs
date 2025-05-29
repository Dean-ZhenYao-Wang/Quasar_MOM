namespace MOM.Domain.isa95.CommonObjectModels.Part2.ProcessSegment
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.EquipmentSegmentSpecificationProperty;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class EquipmentSegmentSpecificationProperty : BaseEntity, IEquatable<EquipmentSegmentSpecificationProperty>
    {
        public EquipmentSegmentSpecificationProperty()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:EquipmentSegmentSpecificationProperty;1";

        [JsonPropertyName("value")]
        public string? Value { get; set; }

        [JsonPropertyName("valueUnitOfMeasure")]
        public string? ValueUnitOfMeasure { get; set; }

        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        [JsonPropertyName("quantityUnitOfMeasure")]
        public string? QuantityUnitOfMeasure { get; set; }

        [JsonIgnore]
public virtual List<EquipmentSegmentSpecificationPropertyContainsRelationship> Contains { get; set; } = new List<EquipmentSegmentSpecificationPropertyContainsRelationship>();

        [JsonIgnore]
public virtual List<EquipmentSegmentSpecificationPropertyMapsToClassPropertyRelationship> MapsToClassProperty { get; set; } = new List<EquipmentSegmentSpecificationPropertyMapsToClassPropertyRelationship>();

        [JsonIgnore]
public virtual List<EquipmentSegmentSpecificationPropertyMapsToPropertyRelationship> MapsToProperty { get; set; } = new List<EquipmentSegmentSpecificationPropertyMapsToPropertyRelationship>();

        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentSegmentSpecificationProperty);
        }

        public bool Equals(EquipmentSegmentSpecificationProperty? other)
        {
            return other is not null && base.Equals(other) && Value == other.Value && ValueUnitOfMeasure == other.ValueUnitOfMeasure && Quantity == other.Quantity && QuantityUnitOfMeasure == other.QuantityUnitOfMeasure;
        }

        public static bool operator ==(EquipmentSegmentSpecificationProperty? left, EquipmentSegmentSpecificationProperty? right)
        {
            return EqualityComparer<EquipmentSegmentSpecificationProperty?>.Default.Equals(left, right);
        }

        public static bool operator !=(EquipmentSegmentSpecificationProperty? left, EquipmentSegmentSpecificationProperty? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Value?.GetHashCode(), ValueUnitOfMeasure?.GetHashCode(), Quantity?.GetHashCode(), QuantityUnitOfMeasure?.GetHashCode());
        }
    }
}