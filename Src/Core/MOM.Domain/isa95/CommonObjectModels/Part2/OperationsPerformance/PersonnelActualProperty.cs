namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationsPerformance
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.PersonnelActualProperty;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class PersonnelActualProperty : BaseEntity, IEquatable<PersonnelActualProperty>
    {
        public PersonnelActualProperty()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:PersonnelActualProperty;1";

        [JsonPropertyName("value")]
        public string? Value { get; set; }

        [JsonPropertyName("valueUnitOfMeasure")]
        public string? ValueUnitOfMeasure { get; set; }

        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        [JsonPropertyName("quantityUnitOfMeasure")]
        public string? QuantityUnitOfMeasure { get; set; }

        [JsonIgnore]
        public virtual PersonnelActualPropertyContainsRelationshipCollection Contains { get; set; } = new PersonnelActualPropertyContainsRelationshipCollection();

        [JsonIgnore]
        public virtual PersonnelActualPropertyMapsToClassPropertyRelationshipCollection MapsToClassProperty { get; set; } = new PersonnelActualPropertyMapsToClassPropertyRelationshipCollection();

        [JsonIgnore]
        public virtual PersonnelActualPropertyMapsToPropertyRelationshipCollection MapsToProperty { get; set; } = new PersonnelActualPropertyMapsToPropertyRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as PersonnelActualProperty);
        }

        public bool Equals(PersonnelActualProperty? other)
        {
            return other is not null && base.Equals(other) && Value == other.Value && ValueUnitOfMeasure == other.ValueUnitOfMeasure && Quantity == other.Quantity && QuantityUnitOfMeasure == other.QuantityUnitOfMeasure;
        }

        public static bool operator ==(PersonnelActualProperty? left, PersonnelActualProperty? right)
        {
            return EqualityComparer<PersonnelActualProperty?>.Default.Equals(left, right);
        }

        public static bool operator !=(PersonnelActualProperty? left, PersonnelActualProperty? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Value?.GetHashCode(), ValueUnitOfMeasure?.GetHashCode(), Quantity?.GetHashCode(), QuantityUnitOfMeasure?.GetHashCode());
        }
    }
}