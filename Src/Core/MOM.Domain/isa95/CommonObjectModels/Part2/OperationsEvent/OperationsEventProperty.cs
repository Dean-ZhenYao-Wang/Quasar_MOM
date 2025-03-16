namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationsEvent
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.OperationsEventProperty;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class OperationsEventProperty : BaseEntity, IEquatable<OperationsEventProperty>
    {
        public OperationsEventProperty()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:OperationsEventProperty;1";

        [JsonPropertyName("propertyType")]
        public OperationsEventPropertyPropertyType? PropertyType { get; set; }

        [JsonPropertyName("value")]
        public string? Value { get; set; }

        [JsonPropertyName("valueUnitOfMeasure")]
        public string? ValueUnitOfMeasure { get; set; }

        [JsonIgnore]
        public virtual OperationsEventPropertyMapsToRelationshipCollection MapsTo { get; set; } = new OperationsEventPropertyMapsToRelationshipCollection();

        [JsonIgnore]
        public virtual OperationsEventPropertyContainsRelationshipCollection Contains { get; set; } = new OperationsEventPropertyContainsRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsEventProperty);
        }

        public bool Equals(OperationsEventProperty? other)
        {
            return other is not null && base.Equals(other) && PropertyType == other.PropertyType && Value == other.Value && ValueUnitOfMeasure == other.ValueUnitOfMeasure;
        }

        public static bool operator ==(OperationsEventProperty? left, OperationsEventProperty? right)
        {
            return EqualityComparer<OperationsEventProperty?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsEventProperty? left, OperationsEventProperty? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), PropertyType?.GetHashCode(), Value?.GetHashCode(), ValueUnitOfMeasure?.GetHashCode());
        }
    }
}