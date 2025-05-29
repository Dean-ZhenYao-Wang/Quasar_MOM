namespace MOM.Domain.isa95.CommonObjectModels.Part4.ResourceRelationship
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.FromResourceReferenceProperty;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class FromResourceReferenceProperty : BaseEntity, IEquatable<FromResourceReferenceProperty>
    {
        public FromResourceReferenceProperty()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:FromResourceReferenceProperty;1";

        [JsonPropertyName("value")]
        public string? Value { get; set; }

        [JsonPropertyName("valueUnitOfMeasure")]
        public string? ValueUnitOfMeasure { get; set; }

        [JsonIgnore]
public virtual List<FromResourceReferencePropertyContainsRelationship> Contains { get; set; } = new List<FromResourceReferencePropertyContainsRelationship>();

        [JsonIgnore]
public virtual List<FromResourceReferencePropertyMapsToClassPropertyRelationship> MapsToClassProperty { get; set; } = new List<FromResourceReferencePropertyMapsToClassPropertyRelationship>();

        [JsonIgnore]
public virtual List<FromResourceReferencePropertyMapsToPropertyRelationship> MapsToProperty { get; set; } = new List<FromResourceReferencePropertyMapsToPropertyRelationship>();

        public override bool Equals(object? obj)
        {
            return Equals(obj as FromResourceReferenceProperty);
        }

        public bool Equals(FromResourceReferenceProperty? other)
        {
            return other is not null && base.Equals(other) && Value == other.Value && ValueUnitOfMeasure == other.ValueUnitOfMeasure;
        }

        public static bool operator ==(FromResourceReferenceProperty? left, FromResourceReferenceProperty? right)
        {
            return EqualityComparer<FromResourceReferenceProperty?>.Default.Equals(left, right);
        }

        public static bool operator !=(FromResourceReferenceProperty? left, FromResourceReferenceProperty? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Value?.GetHashCode(), ValueUnitOfMeasure?.GetHashCode());
        }
    }
}