namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationsEvent
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.OperationsEventDefinitionProperty;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class OperationsEventDefinitionProperty : BaseEntity, IEquatable<OperationsEventDefinitionProperty>
    {
        public OperationsEventDefinitionProperty()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:OperationsEventDefinitionProperty;1";

        [JsonPropertyName("propertyType")]
        public OperationsEventDefinitionPropertyPropertyType? PropertyType { get; set; }

        [JsonPropertyName("value")]
        public string? Value { get; set; }

        [JsonPropertyName("valueUnitOfMeasure")]
        public string? ValueUnitOfMeasure { get; set; }

        [JsonIgnore]
        public virtual OperationsEventDefinitionPropertyMapsToRelationshipCollection MapsTo { get; set; } = new OperationsEventDefinitionPropertyMapsToRelationshipCollection();

        [JsonIgnore]
        public virtual OperationsEventDefinitionPropertyContainsRelationshipCollection Contains { get; set; } = new OperationsEventDefinitionPropertyContainsRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsEventDefinitionProperty);
        }

        public bool Equals(OperationsEventDefinitionProperty? other)
        {
            return other is not null && base.Equals(other) && PropertyType == other.PropertyType && Value == other.Value && ValueUnitOfMeasure == other.ValueUnitOfMeasure;
        }

        public static bool operator ==(OperationsEventDefinitionProperty? left, OperationsEventDefinitionProperty? right)
        {
            return EqualityComparer<OperationsEventDefinitionProperty?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsEventDefinitionProperty? left, OperationsEventDefinitionProperty? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), PropertyType?.GetHashCode(), Value?.GetHashCode(), ValueUnitOfMeasure?.GetHashCode());
        }
    }
}