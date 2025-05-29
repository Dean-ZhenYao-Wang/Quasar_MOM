namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationsSchedule
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.PhysicalAssetRequirementProperty;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class PhysicalAssetRequirementProperty : BaseEntity, IEquatable<PhysicalAssetRequirementProperty>
    {
        public PhysicalAssetRequirementProperty()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:PhysicalAssetRequirementProperty;1";

        [JsonPropertyName("value")]
        public string? Value { get; set; }

        [JsonPropertyName("valueUnitOfMeasure")]
        public string? ValueUnitOfMeasure { get; set; }

        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        [JsonPropertyName("quantityUnitOfMeasure")]
        public string? QuantityUnitOfMeasure { get; set; }

        [JsonIgnore]
public virtual List<PhysicalAssetRequirementPropertyContainsRelationship> Contains { get; set; } = new List<PhysicalAssetRequirementPropertyContainsRelationship>();

        [JsonIgnore]
public virtual List<PhysicalAssetRequirementPropertyMapsToClassPropertyRelationship> MapsToClassProperty { get; set; } = new List<PhysicalAssetRequirementPropertyMapsToClassPropertyRelationship>();

        [JsonIgnore]
public virtual List<PhysicalAssetRequirementPropertyMapsToPropertyRelationship> MapsToProperty { get; set; } = new List<PhysicalAssetRequirementPropertyMapsToPropertyRelationship>();

        public override bool Equals(object? obj)
        {
            return Equals(obj as PhysicalAssetRequirementProperty);
        }

        public bool Equals(PhysicalAssetRequirementProperty? other)
        {
            return other is not null && base.Equals(other) && Value == other.Value && ValueUnitOfMeasure == other.ValueUnitOfMeasure && Quantity == other.Quantity && QuantityUnitOfMeasure == other.QuantityUnitOfMeasure;
        }

        public static bool operator ==(PhysicalAssetRequirementProperty? left, PhysicalAssetRequirementProperty? right)
        {
            return EqualityComparer<PhysicalAssetRequirementProperty?>.Default.Equals(left, right);
        }

        public static bool operator !=(PhysicalAssetRequirementProperty? left, PhysicalAssetRequirementProperty? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Value?.GetHashCode(), ValueUnitOfMeasure?.GetHashCode(), Quantity?.GetHashCode(), QuantityUnitOfMeasure?.GetHashCode());
        }
    }
}