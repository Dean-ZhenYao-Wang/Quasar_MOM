namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationsSchedule
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.PersonnelRequirementProperty;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class PersonnelRequirementProperty : BaseEntity, IEquatable<PersonnelRequirementProperty>
    {
        public PersonnelRequirementProperty()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:PersonnelRequirementProperty;1";

        [JsonPropertyName("value")]
        public string? Value { get; set; }

        [JsonPropertyName("valueUnitOfMeasure")]
        public string? ValueUnitOfMeasure { get; set; }

        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        [JsonPropertyName("quantityUnitOfMeasure")]
        public string? QuantityUnitOfMeasure { get; set; }

        [JsonIgnore]
public virtual List<PersonnelRequirementPropertyContainsRelationship> Contains { get; set; } = new List<PersonnelRequirementPropertyContainsRelationship>();

        [JsonIgnore]
public virtual List<PersonnelRequirementPropertyMapsToClassPropertyRelationship> MapsToClassProperty { get; set; } = new List<PersonnelRequirementPropertyMapsToClassPropertyRelationship>();

        [JsonIgnore]
public virtual List<PersonnelRequirementPropertyMapsToPropertyRelationship> MapsToProperty { get; set; } = new List<PersonnelRequirementPropertyMapsToPropertyRelationship>();

        public override bool Equals(object? obj)
        {
            return Equals(obj as PersonnelRequirementProperty);
        }

        public bool Equals(PersonnelRequirementProperty? other)
        {
            return other is not null && base.Equals(other) && Value == other.Value && ValueUnitOfMeasure == other.ValueUnitOfMeasure && Quantity == other.Quantity && QuantityUnitOfMeasure == other.QuantityUnitOfMeasure;
        }

        public static bool operator ==(PersonnelRequirementProperty? left, PersonnelRequirementProperty? right)
        {
            return EqualityComparer<PersonnelRequirementProperty?>.Default.Equals(left, right);
        }

        public static bool operator !=(PersonnelRequirementProperty? left, PersonnelRequirementProperty? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Value?.GetHashCode(), ValueUnitOfMeasure?.GetHashCode(), Quantity?.GetHashCode(), QuantityUnitOfMeasure?.GetHashCode());
        }
    }
}