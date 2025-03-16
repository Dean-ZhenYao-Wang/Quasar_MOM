namespace MOM.Domain.isa95.CommonObjectModels.Part4.ResourceRelationship
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.ToResourceReferenceProperty;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class ToResourceReferenceProperty : BaseEntity, IEquatable<ToResourceReferenceProperty>
    {
        public ToResourceReferenceProperty()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:ToResourceReferenceProperty;1";

        [JsonPropertyName("value")]
        public string? Value { get; set; }

        [JsonPropertyName("valueUnitOfMeasure")]
        public string? ValueUnitOfMeasure { get; set; }

        [JsonIgnore]
        public virtual ToResourceReferencePropertyContainsRelationshipCollection Contains { get; set; } = new ToResourceReferencePropertyContainsRelationshipCollection();

        [JsonIgnore]
        public virtual ToResourceReferencePropertyMapsToClassPropertyRelationshipCollection MapsToClassProperty { get; set; } = new ToResourceReferencePropertyMapsToClassPropertyRelationshipCollection();

        [JsonIgnore]
        public virtual ToResourceReferencePropertyMapsToPropertyRelationshipCollection MapsToProperty { get; set; } = new ToResourceReferencePropertyMapsToPropertyRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as ToResourceReferenceProperty);
        }

        public bool Equals(ToResourceReferenceProperty? other)
        {
            return other is not null && base.Equals(other) && Value == other.Value && ValueUnitOfMeasure == other.ValueUnitOfMeasure;
        }

        public static bool operator ==(ToResourceReferenceProperty? left, ToResourceReferenceProperty? right)
        {
            return EqualityComparer<ToResourceReferenceProperty?>.Default.Equals(left, right);
        }

        public static bool operator !=(ToResourceReferenceProperty? left, ToResourceReferenceProperty? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Value?.GetHashCode(), ValueUnitOfMeasure?.GetHashCode());
        }
    }
}