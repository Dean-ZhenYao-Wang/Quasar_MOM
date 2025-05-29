namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationsPerformance
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.EquipmentActualProperty;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class EquipmentActualProperty : BaseEntity, IEquatable<EquipmentActualProperty>
    {
        public EquipmentActualProperty()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:EquipmentActualProperty;1";

        [JsonPropertyName("value")]
        public string? Value { get; set; }

        [JsonPropertyName("valueUnitOfMeasure")]
        public string? ValueUnitOfMeasure { get; set; }

        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        [JsonPropertyName("quantityUnitOfMeasure")]
        public string? QuantityUnitOfMeasure { get; set; }

        [JsonIgnore]
public virtual List<EquipmentActualPropertyContainsRelationship> Contains { get; set; } = new List<EquipmentActualPropertyContainsRelationship>();

        [JsonIgnore]
public virtual List<EquipmentActualPropertyMapsToClassPropertyRelationship> MapsToClassProperty { get; set; } = new List<EquipmentActualPropertyMapsToClassPropertyRelationship>();

        [JsonIgnore]
public virtual List<EquipmentActualPropertyMapsToPropertyRelationship> MapsToProperty { get; set; } = new List<EquipmentActualPropertyMapsToPropertyRelationship>();

        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentActualProperty);
        }

        public bool Equals(EquipmentActualProperty? other)
        {
            return other is not null && base.Equals(other) && Value == other.Value && ValueUnitOfMeasure == other.ValueUnitOfMeasure && Quantity == other.Quantity && QuantityUnitOfMeasure == other.QuantityUnitOfMeasure;
        }

        public static bool operator ==(EquipmentActualProperty? left, EquipmentActualProperty? right)
        {
            return EqualityComparer<EquipmentActualProperty?>.Default.Equals(left, right);
        }

        public static bool operator !=(EquipmentActualProperty? left, EquipmentActualProperty? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Value?.GetHashCode(), ValueUnitOfMeasure?.GetHashCode(), Quantity?.GetHashCode(), QuantityUnitOfMeasure?.GetHashCode());
        }
    }
}