namespace MOM.Domain.isa95.CommonObjectModels.Part2.ProcessSegment
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.PhysicalAssetSegmentSpecificationProperty;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class PhysicalAssetSegmentSpecificationProperty : BaseEntity, IEquatable<PhysicalAssetSegmentSpecificationProperty>
    {
        public PhysicalAssetSegmentSpecificationProperty()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:PhysicalAssetSegmentSpecificationProperty;1";

        [JsonPropertyName("value")]
        public string? Value { get; set; }

        [JsonPropertyName("valueUnitOfMeasure")]
        public string? ValueUnitOfMeasure { get; set; }

        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        [JsonPropertyName("quantityUnitOfMeasure")]
        public string? QuantityUnitOfMeasure { get; set; }

        [JsonIgnore]
        public virtual PhysicalAssetSegmentSpecificationPropertyContainsRelationshipCollection Contains { get; set; } = new PhysicalAssetSegmentSpecificationPropertyContainsRelationshipCollection();

        [JsonIgnore]
        public virtual PhysicalAssetSegmentSpecificationPropertyMapsToClassPropertyRelationshipCollection MapsToClassProperty { get; set; } = new PhysicalAssetSegmentSpecificationPropertyMapsToClassPropertyRelationshipCollection();

        [JsonIgnore]
        public virtual PhysicalAssetSegmentSpecificationPropertyMapsToPropertyRelationshipCollection MapsToProperty { get; set; } = new PhysicalAssetSegmentSpecificationPropertyMapsToPropertyRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as PhysicalAssetSegmentSpecificationProperty);
        }

        public bool Equals(PhysicalAssetSegmentSpecificationProperty? other)
        {
            return other is not null && base.Equals(other) && Value == other.Value && ValueUnitOfMeasure == other.ValueUnitOfMeasure && Quantity == other.Quantity && QuantityUnitOfMeasure == other.QuantityUnitOfMeasure;
        }

        public static bool operator ==(PhysicalAssetSegmentSpecificationProperty? left, PhysicalAssetSegmentSpecificationProperty? right)
        {
            return EqualityComparer<PhysicalAssetSegmentSpecificationProperty?>.Default.Equals(left, right);
        }

        public static bool operator !=(PhysicalAssetSegmentSpecificationProperty? left, PhysicalAssetSegmentSpecificationProperty? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Value?.GetHashCode(), ValueUnitOfMeasure?.GetHashCode(), Quantity?.GetHashCode(), QuantityUnitOfMeasure?.GetHashCode());
        }
    }
}