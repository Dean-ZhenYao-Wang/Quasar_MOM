namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationsCapability
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.MaterialCapabilityProperty;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class MaterialCapabilityProperty : BaseEntity, IEquatable<MaterialCapabilityProperty>
    {
        public MaterialCapabilityProperty()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:MaterialCapabilityProperty;1";

        [JsonPropertyName("value")]
        public string? Value { get; set; }

        [JsonPropertyName("valueUnitOfMeasure")]
        public string? ValueUnitOfMeasure { get; set; }

        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        [JsonPropertyName("quantityUnitOfMeasure")]
        public string? QuantityUnitOfMeasure { get; set; }

        [JsonIgnore]
public virtual List<MaterialCapabilityPropertyContainsRelationship> Contains { get; set; } = new List<MaterialCapabilityPropertyContainsRelationship>();

        [JsonIgnore]
public virtual List<MaterialCapabilityPropertyMapsToClassPropertyRelationship> MapsToClassProperty { get; set; } = new List<MaterialCapabilityPropertyMapsToClassPropertyRelationship>();

        [JsonIgnore]
public virtual List<MaterialCapabilityPropertyMapsToDefinitionPropertyRelationship> MapsToDefinitionProperty { get; set; } = new List<MaterialCapabilityPropertyMapsToDefinitionPropertyRelationship>();

        [JsonIgnore]
public virtual List<MaterialCapabilityPropertyMapsToLotPropertyRelationship> MapsToLotProperty { get; set; } = new List<MaterialCapabilityPropertyMapsToLotPropertyRelationship>();

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialCapabilityProperty);
        }

        public bool Equals(MaterialCapabilityProperty? other)
        {
            return other is not null && base.Equals(other) && Value == other.Value && ValueUnitOfMeasure == other.ValueUnitOfMeasure && Quantity == other.Quantity && QuantityUnitOfMeasure == other.QuantityUnitOfMeasure;
        }

        public static bool operator ==(MaterialCapabilityProperty? left, MaterialCapabilityProperty? right)
        {
            return EqualityComparer<MaterialCapabilityProperty?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialCapabilityProperty? left, MaterialCapabilityProperty? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Value?.GetHashCode(), ValueUnitOfMeasure?.GetHashCode(), Quantity?.GetHashCode(), QuantityUnitOfMeasure?.GetHashCode());
        }
    }
}