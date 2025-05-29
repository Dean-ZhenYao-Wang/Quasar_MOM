namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationsDefinition
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.MaterialSpecificationProperty;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public partial class MaterialSpecificationProperty : BaseEntity, IEquatable<MaterialSpecificationProperty>
    {
        public MaterialSpecificationProperty()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:MaterialSpecificationProperty;1";

        [JsonPropertyName("value")]
        public string? Value { get; set; }

        [JsonPropertyName("valueUnitOfMeasure")]
        public string? ValueUnitOfMeasure { get; set; }

        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        [JsonPropertyName("quantityUnitOfMeasure")]
        public string? QuantityUnitOfMeasure { get; set; }

        [JsonIgnore]
public virtual List<MaterialSpecificationPropertyContainsRelationship> Contains { get; set; } = new List<MaterialSpecificationPropertyContainsRelationship>();

        [JsonIgnore]
public virtual List<MaterialSpecificationPropertyMapsToClassPropertyRelationship> MapsToClassProperty { get; set; } = new List<MaterialSpecificationPropertyMapsToClassPropertyRelationship>();

        [JsonIgnore]
public virtual List<MaterialSpecificationPropertyMapsToDefinitionPropertyRelationship> MapsToDefinitionProperty { get; set; } = new List<MaterialSpecificationPropertyMapsToDefinitionPropertyRelationship>();

        [JsonIgnore]
public virtual List<MaterialSpecificationPropertyMapsToLotPropertyRelationship> MapsToLotProperty { get; set; } = new List<MaterialSpecificationPropertyMapsToLotPropertyRelationship>();

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialSpecificationProperty);
        }

        public bool Equals(MaterialSpecificationProperty? other)
        {
            return other is not null && base.Equals(other) && Value == other.Value && ValueUnitOfMeasure == other.ValueUnitOfMeasure && Quantity == other.Quantity && QuantityUnitOfMeasure == other.QuantityUnitOfMeasure;
        }

        public static bool operator ==(MaterialSpecificationProperty? left, MaterialSpecificationProperty? right)
        {
            return EqualityComparer<MaterialSpecificationProperty?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialSpecificationProperty? left, MaterialSpecificationProperty? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Value?.GetHashCode(), ValueUnitOfMeasure?.GetHashCode(), Quantity?.GetHashCode(), QuantityUnitOfMeasure?.GetHashCode());
        }
    }
}