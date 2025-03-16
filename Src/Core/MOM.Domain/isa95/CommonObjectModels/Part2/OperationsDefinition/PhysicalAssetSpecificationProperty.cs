namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationsDefinition
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.PhysicalAssetSpecificationProperty;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class PhysicalAssetSpecificationProperty : BaseEntity, IEquatable<PhysicalAssetSpecificationProperty>
    {
        public PhysicalAssetSpecificationProperty()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:PhysicalAssetSpecificationProperty;1";

        [JsonPropertyName("value")]
        public string? Value { get; set; }

        [JsonPropertyName("valueUnitOfMeasure")]
        public string? ValueUnitOfMeasure { get; set; }

        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        [JsonPropertyName("quantityUnitOfMeasure")]
        public string? QuantityUnitOfMeasure { get; set; }

        [JsonIgnore]
        public virtual PhysicalAssetSpecificationPropertyContainsRelationshipCollection Contains { get; set; } = new PhysicalAssetSpecificationPropertyContainsRelationshipCollection();

        [JsonIgnore]
        public virtual PhysicalAssetSpecificationPropertyMapsToClassPropertyRelationshipCollection MapsToClassProperty { get; set; } = new PhysicalAssetSpecificationPropertyMapsToClassPropertyRelationshipCollection();

        [JsonIgnore]
        public virtual PhysicalAssetSpecificationPropertyMapsToPropertyRelationshipCollection MapsToProperty { get; set; } = new PhysicalAssetSpecificationPropertyMapsToPropertyRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as PhysicalAssetSpecificationProperty);
        }

        public bool Equals(PhysicalAssetSpecificationProperty? other)
        {
            return other is not null && base.Equals(other) && Value == other.Value && ValueUnitOfMeasure == other.ValueUnitOfMeasure && Quantity == other.Quantity && QuantityUnitOfMeasure == other.QuantityUnitOfMeasure;
        }

        public static bool operator ==(PhysicalAssetSpecificationProperty? left, PhysicalAssetSpecificationProperty? right)
        {
            return EqualityComparer<PhysicalAssetSpecificationProperty?>.Default.Equals(left, right);
        }

        public static bool operator !=(PhysicalAssetSpecificationProperty? left, PhysicalAssetSpecificationProperty? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Value?.GetHashCode(), ValueUnitOfMeasure?.GetHashCode(), Quantity?.GetHashCode(), QuantityUnitOfMeasure?.GetHashCode());
        }
    }
}