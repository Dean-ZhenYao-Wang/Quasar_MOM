namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationsDefinition
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.EquipmentSpecificationProperty;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class EquipmentSpecificationProperty : BaseEntity, IEquatable<EquipmentSpecificationProperty>
    {
        public EquipmentSpecificationProperty()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:EquipmentSpecificationProperty;1";

        [JsonPropertyName("value")]
        public string? Value { get; set; }

        [JsonPropertyName("valueUnitOfMeasure")]
        public string? ValueUnitOfMeasure { get; set; }

        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        [JsonPropertyName("quantityUnitOfMeasure")]
        public string? QuantityUnitOfMeasure { get; set; }

        [JsonIgnore]
        public virtual EquipmentSpecificationPropertyContainsRelationshipCollection Contains { get; set; } = new EquipmentSpecificationPropertyContainsRelationshipCollection();

        [JsonIgnore]
        public virtual EquipmentSpecificationPropertyMapsToClassPropertyRelationshipCollection MapsToClassProperty { get; set; } = new EquipmentSpecificationPropertyMapsToClassPropertyRelationshipCollection();

        [JsonIgnore]
        public virtual EquipmentSpecificationPropertyMapsToPropertyRelationshipCollection MapsToProperty { get; set; } = new EquipmentSpecificationPropertyMapsToPropertyRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentSpecificationProperty);
        }

        public bool Equals(EquipmentSpecificationProperty? other)
        {
            return other is not null && base.Equals(other) && Value == other.Value && ValueUnitOfMeasure == other.ValueUnitOfMeasure && Quantity == other.Quantity && QuantityUnitOfMeasure == other.QuantityUnitOfMeasure;
        }

        public static bool operator ==(EquipmentSpecificationProperty? left, EquipmentSpecificationProperty? right)
        {
            return EqualityComparer<EquipmentSpecificationProperty?>.Default.Equals(left, right);
        }

        public static bool operator !=(EquipmentSpecificationProperty? left, EquipmentSpecificationProperty? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Value?.GetHashCode(), ValueUnitOfMeasure?.GetHashCode(), Quantity?.GetHashCode(), QuantityUnitOfMeasure?.GetHashCode());
        }
    }
}