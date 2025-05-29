namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationsDefinition
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.PersonnelSpecificationProperty;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class PersonnelSpecificationProperty : BaseEntity, IEquatable<PersonnelSpecificationProperty>
    {
        public PersonnelSpecificationProperty()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:PersonnelSpecificationProperty;1";

        [JsonPropertyName("value")]
        public string? Value { get; set; }

        [JsonPropertyName("valueUnitOfMeasure")]
        public string? ValueUnitOfMeasure { get; set; }

        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        [JsonPropertyName("quantityUnitOfMeasure")]
        public string? QuantityUnitOfMeasure { get; set; }

        [JsonIgnore]
public virtual List<PersonnelSpecificationPropertyContainsRelationship> Contains { get; set; } = new List<PersonnelSpecificationPropertyContainsRelationship>();

        [JsonIgnore]
public virtual List<PersonnelSpecificationPropertyMapsToClassPropertyRelationship> MapsToClassProperty { get; set; } = new List<PersonnelSpecificationPropertyMapsToClassPropertyRelationship>();

        [JsonIgnore]
public virtual List<PersonnelSpecificationPropertyMapsToPropertyRelationship> MapsToProperty { get; set; } = new List<PersonnelSpecificationPropertyMapsToPropertyRelationship>();

        public override bool Equals(object? obj)
        {
            return Equals(obj as PersonnelSpecificationProperty);
        }

        public bool Equals(PersonnelSpecificationProperty? other)
        {
            return other is not null && base.Equals(other) && Value == other.Value && ValueUnitOfMeasure == other.ValueUnitOfMeasure && Quantity == other.Quantity && QuantityUnitOfMeasure == other.QuantityUnitOfMeasure;
        }

        public static bool operator ==(PersonnelSpecificationProperty? left, PersonnelSpecificationProperty? right)
        {
            return EqualityComparer<PersonnelSpecificationProperty?>.Default.Equals(left, right);
        }

        public static bool operator !=(PersonnelSpecificationProperty? left, PersonnelSpecificationProperty? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Value?.GetHashCode(), ValueUnitOfMeasure?.GetHashCode(), Quantity?.GetHashCode(), QuantityUnitOfMeasure?.GetHashCode());
        }
    }
}