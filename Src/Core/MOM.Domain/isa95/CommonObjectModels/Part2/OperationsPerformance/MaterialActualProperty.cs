namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationsPerformance
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.MaterialActualProperty;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public partial class MaterialActualProperty : BaseEntity, IEquatable<MOM.Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.MaterialActualProperty>
    {
        public MaterialActualProperty()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:MaterialActualProperty;1";

        [JsonPropertyName("value")]
        public string? Value { get; set; }

        [JsonPropertyName("valueUnitOfMeasure")]
        public string? ValueUnitOfMeasure { get; set; }

        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        [JsonPropertyName("quantityUnitOfMeasure")]
        public string? QuantityUnitOfMeasure { get; set; }

        [JsonIgnore]
public virtual List<MaterialActualPropertyContainsRelationship> Contains { get; set; } = new List<MaterialActualPropertyContainsRelationship>();

        [JsonIgnore]
public virtual List<MaterialActualPropertyMapsToClassPropertyRelationship> MapsToClassProperty { get; set; } = new List<MaterialActualPropertyMapsToClassPropertyRelationship>();

        [JsonIgnore]
public virtual List<MaterialActualPropertyMapsToDefinitionPropertyRelationship> MapsToDefinitionProperty { get; set; } = new List<MaterialActualPropertyMapsToDefinitionPropertyRelationship>();

        [JsonIgnore]
public virtual List<MaterialActualPropertyMapsToLotPropertyRelationship> MapsToLotProperty { get; set; } = new List<MaterialActualPropertyMapsToLotPropertyRelationship>();

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialActualProperty);
        }

        public bool Equals(MaterialActualProperty? other)
        {
            return other is not null && base.Equals(other) && Value == other.Value && ValueUnitOfMeasure == other.ValueUnitOfMeasure && Quantity == other.Quantity && QuantityUnitOfMeasure == other.QuantityUnitOfMeasure;
        }

        public static bool operator ==(MaterialActualProperty? left, MaterialActualProperty? right)
        {
            return EqualityComparer<MaterialActualProperty?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialActualProperty? left, MaterialActualProperty? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Value?.GetHashCode(), ValueUnitOfMeasure?.GetHashCode(), Quantity?.GetHashCode(), QuantityUnitOfMeasure?.GetHashCode());
        }
    }
}