namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationalLocation
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.OperationalLocationClassProperty;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class OperationalLocationClassProperty : BaseEntity, IEquatable<OperationalLocationClassProperty>
    {
        public OperationalLocationClassProperty()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:OperationalLocationClassProperty;1";

        [JsonPropertyName("value")]
        public string? Value { get; set; }

        [JsonPropertyName("valueUnitOfMeasure")]
        public string? ValueUnitOfMeasure { get; set; }

        [JsonPropertyName("propertyType")]
        public virtual OperationalLocationClassPropertyPropertyType? PropertyType { get; set; }

        [JsonIgnore]
        public virtual OperationalLocationClassPropertyContainsRelationshipCollection Contains { get; set; } = new OperationalLocationClassPropertyContainsRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationalLocationClassProperty);
        }

        public bool Equals(OperationalLocationClassProperty? other)
        {
            return other is not null && base.Equals(other) && Value == other.Value && ValueUnitOfMeasure == other.ValueUnitOfMeasure && PropertyType == other.PropertyType;
        }

        public static bool operator ==(OperationalLocationClassProperty? left, OperationalLocationClassProperty? right)
        {
            return EqualityComparer<OperationalLocationClassProperty?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationalLocationClassProperty? left, OperationalLocationClassProperty? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Value?.GetHashCode(), ValueUnitOfMeasure?.GetHashCode(), PropertyType?.GetHashCode());
        }
    }
}