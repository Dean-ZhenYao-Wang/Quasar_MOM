namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationsPerformance
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.PhysicalAssetActual;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class PhysicalAssetActual : BaseEntity, IEquatable<PhysicalAssetActual>
    {
        public PhysicalAssetActual()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:PhysicalAssetActual;1";

        [JsonPropertyName("hierarchyScope")]
        public string? HierarchyScope { get; set; }

        [JsonPropertyName("physicalLocation")]
        public string? PhysicalLocation { get; set; }

        [JsonPropertyName("physicalLocationType")]
        public PhysicalAssetActualPhysicalLocationType? PhysicalLocationType { get; set; }

        [JsonPropertyName("physicalAssetUse")]
        public string? PhysicalAssetUse { get; set; }

        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        [JsonPropertyName("quantityUnitOfMeasure")]
        public string? QuantityUnitOfMeasure { get; set; }

        [JsonIgnore]
public virtual List<PhysicalAssetActualIsMadeUpOfRelationship> IsMadeUpOf { get; set; } = new List<PhysicalAssetActualIsMadeUpOfRelationship>();

        [JsonIgnore]
public virtual List<PhysicalAssetActualHasValuesOfRelationship> HasValuesOf { get; set; } = new List<PhysicalAssetActualHasValuesOfRelationship>();

        [JsonIgnore]
public virtual List<PhysicalAssetActualCorrespondsToPhysicalAssetClassRelationship> CorrespondsToPhysicalAssetClass { get; set; } = new List<PhysicalAssetActualCorrespondsToPhysicalAssetClassRelationship>();

        [JsonIgnore]
public virtual List<PhysicalAssetActualCorrespondsToPhysicalAssetRelationship> CorrespondsToPhysicalAsset { get; set; } = new List<PhysicalAssetActualCorrespondsToPhysicalAssetRelationship>();

        [JsonIgnore]
public virtual List<PhysicalAssetActualHierarchyScopeRelRelationship> HierarchyScopeRel { get; set; } = new List<PhysicalAssetActualHierarchyScopeRelRelationship>();

        [JsonIgnore]
public virtual List<PhysicalAssetActualPhysicalLocationRelRelationship> PhysicalLocationRel { get; set; } = new List<PhysicalAssetActualPhysicalLocationRelRelationship>();

        public override bool Equals(object? obj)
        {
            return Equals(obj as PhysicalAssetActual);
        }

        public bool Equals(PhysicalAssetActual? other)
        {
            return other is not null && base.Equals(other) && HierarchyScope == other.HierarchyScope && PhysicalLocation == other.PhysicalLocation && PhysicalLocationType == other.PhysicalLocationType && PhysicalAssetUse == other.PhysicalAssetUse && Quantity == other.Quantity && QuantityUnitOfMeasure == other.QuantityUnitOfMeasure;
        }

        public static bool operator ==(PhysicalAssetActual? left, PhysicalAssetActual? right)
        {
            return EqualityComparer<PhysicalAssetActual?>.Default.Equals(left, right);
        }

        public static bool operator !=(PhysicalAssetActual? left, PhysicalAssetActual? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), HierarchyScope?.GetHashCode(), PhysicalLocation?.GetHashCode(), PhysicalLocationType?.GetHashCode(), PhysicalAssetUse?.GetHashCode(), Quantity?.GetHashCode(), QuantityUnitOfMeasure?.GetHashCode());
        }
    }
}