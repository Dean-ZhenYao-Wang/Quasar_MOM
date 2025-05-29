namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationsCapability
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.EquipmentCapabilityProperty;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class EquipmentCapabilityProperty : BaseEntity, IEquatable<EquipmentCapabilityProperty>
    {
        public EquipmentCapabilityProperty()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:EquipmentCapabilityProperty;1";

        [JsonPropertyName("value")]
        public string? Value { get; set; }

        [JsonPropertyName("valueUnitOfMeasure")]
        public string? ValueUnitOfMeasure { get; set; }

        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        [JsonPropertyName("quantityUnitOfMeasure")]
        public string? QuantityUnitOfMeasure { get; set; }

        [JsonIgnore]
public virtual List<EquipmentCapabilityPropertyContainsRelationship> Contains { get; set; } = new List<EquipmentCapabilityPropertyContainsRelationship>();

        [JsonIgnore]
public virtual List<EquipmentCapabilityPropertyMapsToClassPropertyRelationship> MapsToClassProperty { get; set; } = new List<EquipmentCapabilityPropertyMapsToClassPropertyRelationship>();

        [JsonIgnore]
public virtual List<EquipmentCapabilityPropertyMapsToPropertyRelationship> MapsToProperty { get; set; } = new List<EquipmentCapabilityPropertyMapsToPropertyRelationship>();

        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentCapabilityProperty);
        }

        public bool Equals(EquipmentCapabilityProperty? other)
        {
            return other is not null && base.Equals(other) && Value == other.Value && ValueUnitOfMeasure == other.ValueUnitOfMeasure && Quantity == other.Quantity && QuantityUnitOfMeasure == other.QuantityUnitOfMeasure;
        }

        public static bool operator ==(EquipmentCapabilityProperty? left, EquipmentCapabilityProperty? right)
        {
            return EqualityComparer<EquipmentCapabilityProperty?>.Default.Equals(left, right);
        }

        public static bool operator !=(EquipmentCapabilityProperty? left, EquipmentCapabilityProperty? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Value?.GetHashCode(), ValueUnitOfMeasure?.GetHashCode(), Quantity?.GetHashCode(), QuantityUnitOfMeasure?.GetHashCode());
        }
    }
}