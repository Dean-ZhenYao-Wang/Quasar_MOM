namespace MOM.Domain.isa95.CommonObjectModels.Part2.ProcessSegment
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.PersonnelSegmentSpecificationProperty;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class PersonnelSegmentSpecificationProperty : BaseEntity, IEquatable<PersonnelSegmentSpecificationProperty>
    {
        public PersonnelSegmentSpecificationProperty()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:PersonnelSegmentSpecificationProperty;1";

        [JsonPropertyName("value")]
        public string? Value { get; set; }

        [JsonPropertyName("valueUnitOfMeasure")]
        public string? ValueUnitOfMeasure { get; set; }

        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        [JsonPropertyName("quantityUnitOfMeasure")]
        public string? QuantityUnitOfMeasure { get; set; }

        [JsonIgnore]
        public virtual PersonnelSegmentSpecificationPropertyContainsRelationshipCollection Contains { get; set; } = new PersonnelSegmentSpecificationPropertyContainsRelationshipCollection();

        [JsonIgnore]
        public virtual PersonnelSegmentSpecificationPropertyMapsToClassPropertyRelationshipCollection MapsToClassProperty { get; set; } = new PersonnelSegmentSpecificationPropertyMapsToClassPropertyRelationshipCollection();

        [JsonIgnore]
        public virtual PersonnelSegmentSpecificationPropertyMapsToPropertyRelationshipCollection MapsToProperty { get; set; } = new PersonnelSegmentSpecificationPropertyMapsToPropertyRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as PersonnelSegmentSpecificationProperty);
        }

        public bool Equals(PersonnelSegmentSpecificationProperty? other)
        {
            return other is not null && base.Equals(other) && Value == other.Value && ValueUnitOfMeasure == other.ValueUnitOfMeasure && Quantity == other.Quantity && QuantityUnitOfMeasure == other.QuantityUnitOfMeasure;
        }

        public static bool operator ==(PersonnelSegmentSpecificationProperty? left, PersonnelSegmentSpecificationProperty? right)
        {
            return EqualityComparer<PersonnelSegmentSpecificationProperty?>.Default.Equals(left, right);
        }

        public static bool operator !=(PersonnelSegmentSpecificationProperty? left, PersonnelSegmentSpecificationProperty? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Value?.GetHashCode(), ValueUnitOfMeasure?.GetHashCode(), Quantity?.GetHashCode(), QuantityUnitOfMeasure?.GetHashCode());
        }
    }
}