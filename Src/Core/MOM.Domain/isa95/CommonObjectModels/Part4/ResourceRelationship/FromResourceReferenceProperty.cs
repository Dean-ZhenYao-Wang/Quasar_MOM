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
        public virtual FromResourceReferencePropertyContainsRelationshipCollection Contains { get; set; } = new FromResourceReferencePropertyContainsRelationshipCollection();

        [JsonIgnore]
        public virtual FromResourceReferencePropertyMapsToClassPropertyRelationshipCollection MapsToClassProperty { get; set; } = new FromResourceReferencePropertyMapsToClassPropertyRelationshipCollection();

        [JsonIgnore]
        public virtual FromResourceReferencePropertyMapsToPropertyRelationshipCollection MapsToProperty { get; set; } = new FromResourceReferencePropertyMapsToPropertyRelationshipCollection();

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