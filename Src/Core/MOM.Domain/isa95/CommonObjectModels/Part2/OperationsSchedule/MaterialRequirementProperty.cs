namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationsSchedule
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.MaterialRequirementProperty;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class MaterialRequirementProperty : BaseEntity, IEquatable<MaterialRequirementProperty>
    {
        public MaterialRequirementProperty()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:MaterialRequirementProperty;1";

        [JsonPropertyName("value")]
        public string? Value { get; set; }

        [JsonPropertyName("valueUnitOfMeasure")]
        public string? ValueUnitOfMeasure { get; set; }

        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        [JsonPropertyName("quantityUnitOfMeasure")]
        public string? QuantityUnitOfMeasure { get; set; }

        [JsonIgnore]
        public virtual MaterialRequirementPropertyContainsRelationshipCollection Contains { get; set; } = new MaterialRequirementPropertyContainsRelationshipCollection();

        [JsonIgnore]
        public virtual MaterialRequirementPropertyMapsToClassPropertyRelationshipCollection MapsToClassProperty { get; set; } = new MaterialRequirementPropertyMapsToClassPropertyRelationshipCollection();

        [JsonIgnore]
        public virtual MaterialRequirementPropertyMapsToDefinitionPropertyRelationshipCollection MapsToDefinitionProperty { get; set; } = new MaterialRequirementPropertyMapsToDefinitionPropertyRelationshipCollection();

        [JsonIgnore]
        public virtual MaterialRequirementPropertyMapsToLotPropertyRelationshipCollection MapsToLotProperty { get; set; } = new MaterialRequirementPropertyMapsToLotPropertyRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialRequirementProperty);
        }

        public bool Equals(MaterialRequirementProperty? other)
        {
            return other is not null && base.Equals(other) && Value == other.Value && ValueUnitOfMeasure == other.ValueUnitOfMeasure && Quantity == other.Quantity && QuantityUnitOfMeasure == other.QuantityUnitOfMeasure;
        }

        public static bool operator ==(MaterialRequirementProperty? left, MaterialRequirementProperty? right)
        {
            return EqualityComparer<MaterialRequirementProperty?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialRequirementProperty? left, MaterialRequirementProperty? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Value?.GetHashCode(), ValueUnitOfMeasure?.GetHashCode(), Quantity?.GetHashCode(), QuantityUnitOfMeasure?.GetHashCode());
        }
    }
}