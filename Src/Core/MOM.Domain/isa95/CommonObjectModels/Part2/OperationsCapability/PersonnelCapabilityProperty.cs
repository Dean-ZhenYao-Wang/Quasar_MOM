namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationsCapability
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.PersonnelCapabilityProperty;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class PersonnelCapabilityProperty : BaseEntity, IEquatable<PersonnelCapabilityProperty>
    {
        public PersonnelCapabilityProperty()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:PersonnelCapabilityProperty;1";

        [JsonPropertyName("value")]
        public string? Value { get; set; }

        [JsonPropertyName("valueUnitOfMeasure")]
        public string? ValueUnitOfMeasure { get; set; }

        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        [JsonPropertyName("quantityUnitOfMeasure")]
        public string? QuantityUnitOfMeasure { get; set; }

        [JsonIgnore]
        public virtual PersonnelCapabilityPropertyContainsRelationshipCollection Contains { get; set; } = new PersonnelCapabilityPropertyContainsRelationshipCollection();

        [JsonIgnore]
        public virtual PersonnelCapabilityPropertyMapsToClassPropertyRelationshipCollection MapsToClassProperty { get; set; } = new PersonnelCapabilityPropertyMapsToClassPropertyRelationshipCollection();

        [JsonIgnore]
        public virtual PersonnelCapabilityPropertyMapsToPropertyRelationshipCollection MapsToProperty { get; set; } = new PersonnelCapabilityPropertyMapsToPropertyRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as PersonnelCapabilityProperty);
        }

        public bool Equals(PersonnelCapabilityProperty? other)
        {
            return other is not null && base.Equals(other) && Value == other.Value && ValueUnitOfMeasure == other.ValueUnitOfMeasure && Quantity == other.Quantity && QuantityUnitOfMeasure == other.QuantityUnitOfMeasure;
        }

        public static bool operator ==(PersonnelCapabilityProperty? left, PersonnelCapabilityProperty? right)
        {
            return EqualityComparer<PersonnelCapabilityProperty?>.Default.Equals(left, right);
        }

        public static bool operator !=(PersonnelCapabilityProperty? left, PersonnelCapabilityProperty? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Value?.GetHashCode(), ValueUnitOfMeasure?.GetHashCode(), Quantity?.GetHashCode(), QuantityUnitOfMeasure?.GetHashCode());
        }
    }
}