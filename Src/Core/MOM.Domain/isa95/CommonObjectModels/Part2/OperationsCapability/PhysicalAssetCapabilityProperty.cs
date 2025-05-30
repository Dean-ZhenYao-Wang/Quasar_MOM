namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationsCapability
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.PhysicalAssetCapabilityProperty;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class PhysicalAssetCapabilityProperty : BaseEntity, IEquatable<PhysicalAssetCapabilityProperty>
    {
        public PhysicalAssetCapabilityProperty()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:PhysicalAssetCapabilityProperty;1";

        [JsonPropertyName("value")]
        public string? Value { get; set; }

        [JsonPropertyName("valueUnitOfMeasure")]
        public string? ValueUnitOfMeasure { get; set; }

        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        [JsonPropertyName("quantityUnitOfMeasure")]
        public string? QuantityUnitOfMeasure { get; set; }

        [JsonIgnore]
public virtual List<PhysicalAssetCapabilityPropertyContainsRelationship> Contains { get; set; } = new List<PhysicalAssetCapabilityPropertyContainsRelationship>();

        [JsonIgnore]
public virtual List<PhysicalAssetCapabilityPropertyMapsToClassPropertyRelationship> MapsToClassProperty { get; set; } = new List<PhysicalAssetCapabilityPropertyMapsToClassPropertyRelationship>();

        [JsonIgnore]
public virtual List<PhysicalAssetCapabilityPropertyMapsToPropertyRelationship> MapsToProperty { get; set; } = new List<PhysicalAssetCapabilityPropertyMapsToPropertyRelationship>();

        public override bool Equals(object? obj)
        {
            return Equals(obj as PhysicalAssetCapabilityProperty);
        }

        public bool Equals(PhysicalAssetCapabilityProperty? other)
        {
            return other is not null && base.Equals(other) && Value == other.Value && ValueUnitOfMeasure == other.ValueUnitOfMeasure && Quantity == other.Quantity && QuantityUnitOfMeasure == other.QuantityUnitOfMeasure;
        }

        public static bool operator ==(PhysicalAssetCapabilityProperty? left, PhysicalAssetCapabilityProperty? right)
        {
            return EqualityComparer<PhysicalAssetCapabilityProperty?>.Default.Equals(left, right);
        }

        public static bool operator !=(PhysicalAssetCapabilityProperty? left, PhysicalAssetCapabilityProperty? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Value?.GetHashCode(), ValueUnitOfMeasure?.GetHashCode(), Quantity?.GetHashCode(), QuantityUnitOfMeasure?.GetHashCode());
        }
    }
}