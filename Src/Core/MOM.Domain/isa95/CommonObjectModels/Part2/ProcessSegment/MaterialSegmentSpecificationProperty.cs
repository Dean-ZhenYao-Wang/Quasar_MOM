namespace MOM.Domain.isa95.CommonObjectModels.Part2.ProcessSegment
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.MaterialSegmentSpecificationProperty;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class MaterialSegmentSpecificationProperty : BaseEntity, IEquatable<MaterialSegmentSpecificationProperty>
    {
        public MaterialSegmentSpecificationProperty()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:MaterialSegmentSpecificationProperty;1";

        [JsonPropertyName("value")]
        public string? Value { get; set; }

        [JsonPropertyName("valueUnitOfMeasure")]
        public string? ValueUnitOfMeasure { get; set; }

        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        [JsonPropertyName("quantityUnitOfMeasure")]
        public string? QuantityUnitOfMeasure { get; set; }

        [JsonIgnore]
        public virtual MaterialSegmentSpecificationPropertyContainsRelationshipCollection Contains { get; set; } = new MaterialSegmentSpecificationPropertyContainsRelationshipCollection();

        [JsonIgnore]
        public virtual MaterialSegmentSpecificationPropertyMapsToClassPropertyRelationshipCollection MapsToClassProperty { get; set; } = new MaterialSegmentSpecificationPropertyMapsToClassPropertyRelationshipCollection();

        [JsonIgnore]
        public virtual MaterialSegmentSpecificationPropertyMapsToDefinitionPropertyRelationshipCollection MapsToDefinitionProperty { get; set; } = new MaterialSegmentSpecificationPropertyMapsToDefinitionPropertyRelationshipCollection();

        [JsonIgnore]
        public virtual MaterialSegmentSpecificationPropertyMapsToLotPropertyRelationshipCollection MapsToLotProperty { get; set; } = new MaterialSegmentSpecificationPropertyMapsToLotPropertyRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialSegmentSpecificationProperty);
        }

        public bool Equals(MaterialSegmentSpecificationProperty? other)
        {
            return other is not null && base.Equals(other) && Value == other.Value && ValueUnitOfMeasure == other.ValueUnitOfMeasure && Quantity == other.Quantity && QuantityUnitOfMeasure == other.QuantityUnitOfMeasure;
        }

        public static bool operator ==(MaterialSegmentSpecificationProperty? left, MaterialSegmentSpecificationProperty? right)
        {
            return EqualityComparer<MaterialSegmentSpecificationProperty?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialSegmentSpecificationProperty? left, MaterialSegmentSpecificationProperty? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Value?.GetHashCode(), ValueUnitOfMeasure?.GetHashCode(), Quantity?.GetHashCode(), QuantityUnitOfMeasure?.GetHashCode());
        }
    }
}