namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationsEvent
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.OperationsEventClassProperty;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class OperationsEventClassProperty : BaseEntity, IEquatable<OperationsEventClassProperty>
    {
        public OperationsEventClassProperty()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:OperationsEventClassProperty;1";

        [JsonPropertyName("propertyType")]
        public OperationsEventClassPropertyPropertyType? PropertyType { get; set; }

        [JsonPropertyName("value")]
        public string? Value { get; set; }

        [JsonPropertyName("valueUnitOfMeasure")]
        public string? ValueUnitOfMeasure { get; set; }

        [JsonIgnore]
        public virtual OperationsEventClassPropertyContainsRelationshipCollection Contains { get; set; } = new OperationsEventClassPropertyContainsRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsEventClassProperty);
        }

        public bool Equals(OperationsEventClassProperty? other)
        {
            return other is not null && base.Equals(other) && PropertyType == other.PropertyType && Value == other.Value && ValueUnitOfMeasure == other.ValueUnitOfMeasure;
        }

        public static bool operator ==(OperationsEventClassProperty? left, OperationsEventClassProperty? right)
        {
            return EqualityComparer<OperationsEventClassProperty?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsEventClassProperty? left, OperationsEventClassProperty? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), PropertyType?.GetHashCode(), Value?.GetHashCode(), ValueUnitOfMeasure?.GetHashCode());
        }
    }
}