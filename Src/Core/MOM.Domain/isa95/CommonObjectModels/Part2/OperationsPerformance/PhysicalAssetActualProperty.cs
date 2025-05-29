namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationsPerformance
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.PhysicalAssetActualProperty;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class PhysicalAssetActualProperty : BaseEntity, IEquatable<PhysicalAssetActualProperty>
    {
        public PhysicalAssetActualProperty()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:PhysicalAssetActualProperty;1";

        [JsonPropertyName("value")]
        public string? Value { get; set; }

        [JsonPropertyName("valueUnitOfMeasure")]
        public string? ValueUnitOfMeasure { get; set; }

        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        [JsonPropertyName("quantityUnitOfMeasure")]
        public string? QuantityUnitOfMeasure { get; set; }

        [JsonIgnore]
public virtual List<PhysicalAssetActualPropertyContainsRelationship> Contains { get; set; } = new List<PhysicalAssetActualPropertyContainsRelationship>();

        [JsonIgnore]
public virtual List<PhysicalAssetActualPropertyMapsToClassPropertyRelationship> MapsToClassProperty { get; set; } = new List<PhysicalAssetActualPropertyMapsToClassPropertyRelationship>();

        [JsonIgnore]
public virtual List<PhysicalAssetActualPropertyMapsToPropertyRelationship> MapsToProperty { get; set; } = new List<PhysicalAssetActualPropertyMapsToPropertyRelationship>();

        public override bool Equals(object? obj)
        {
            return Equals(obj as PhysicalAssetActualProperty);
        }

        public bool Equals(PhysicalAssetActualProperty? other)
        {
            return other is not null && base.Equals(other) && Value == other.Value && ValueUnitOfMeasure == other.ValueUnitOfMeasure && Quantity == other.Quantity && QuantityUnitOfMeasure == other.QuantityUnitOfMeasure;
        }

        public static bool operator ==(PhysicalAssetActualProperty? left, PhysicalAssetActualProperty? right)
        {
            return EqualityComparer<PhysicalAssetActualProperty?>.Default.Equals(left, right);
        }

        public static bool operator !=(PhysicalAssetActualProperty? left, PhysicalAssetActualProperty? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Value?.GetHashCode(), ValueUnitOfMeasure?.GetHashCode(), Quantity?.GetHashCode(), QuantityUnitOfMeasure?.GetHashCode());
        }
    }
}