namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationsSchedule
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.EquipmentRequirementProperty;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class EquipmentRequirementProperty : BaseEntity, IEquatable<EquipmentRequirementProperty>
    {
        public EquipmentRequirementProperty()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:EquipmentRequirementProperty;1";

        [JsonPropertyName("value")]
        public string? Value { get; set; }

        [JsonPropertyName("valueUnitOfMeasure")]
        public string? ValueUnitOfMeasure { get; set; }

        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        [JsonPropertyName("quantityUnitOfMeasure")]
        public string? QuantityUnitOfMeasure { get; set; }

        [JsonIgnore]
        public virtual EquipmentRequirementPropertyContainsRelationshipCollection Contains { get; set; } = new EquipmentRequirementPropertyContainsRelationshipCollection();

        [JsonIgnore]
        public virtual EquipmentRequirementPropertyMapsToClassPropertyRelationshipCollection MapsToClassProperty { get; set; } = new EquipmentRequirementPropertyMapsToClassPropertyRelationshipCollection();

        [JsonIgnore]
        public virtual EquipmentRequirementPropertyMapsToPropertyRelationshipCollection MapsToProperty { get; set; } = new EquipmentRequirementPropertyMapsToPropertyRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentRequirementProperty);
        }

        public bool Equals(EquipmentRequirementProperty? other)
        {
            return other is not null && base.Equals(other) && Value == other.Value && ValueUnitOfMeasure == other.ValueUnitOfMeasure && Quantity == other.Quantity && QuantityUnitOfMeasure == other.QuantityUnitOfMeasure;
        }

        public static bool operator ==(EquipmentRequirementProperty? left, EquipmentRequirementProperty? right)
        {
            return EqualityComparer<EquipmentRequirementProperty?>.Default.Equals(left, right);
        }

        public static bool operator !=(EquipmentRequirementProperty? left, EquipmentRequirementProperty? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Value?.GetHashCode(), ValueUnitOfMeasure?.GetHashCode(), Quantity?.GetHashCode(), QuantityUnitOfMeasure?.GetHashCode());
        }
    }
}