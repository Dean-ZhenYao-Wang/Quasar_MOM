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
        public virtual PhysicalAssetActualIsMadeUpOfRelationshipCollection IsMadeUpOf { get; set; } = new PhysicalAssetActualIsMadeUpOfRelationshipCollection();

        [JsonIgnore]
        public virtual PhysicalAssetActualHasValuesOfRelationshipCollection HasValuesOf { get; set; } = new PhysicalAssetActualHasValuesOfRelationshipCollection();

        [JsonIgnore]
        public virtual PhysicalAssetActualCorrespondsToPhysicalAssetClassRelationshipCollection CorrespondsToPhysicalAssetClass { get; set; } = new PhysicalAssetActualCorrespondsToPhysicalAssetClassRelationshipCollection();

        [JsonIgnore]
        public virtual PhysicalAssetActualCorrespondsToPhysicalAssetRelationshipCollection CorrespondsToPhysicalAsset { get; set; } = new PhysicalAssetActualCorrespondsToPhysicalAssetRelationshipCollection();

        [JsonIgnore]
        public virtual PhysicalAssetActualHierarchyScopeRelRelationshipCollection HierarchyScopeRel { get; set; } = new PhysicalAssetActualHierarchyScopeRelRelationshipCollection();

        [JsonIgnore]
        public virtual PhysicalAssetActualPhysicalLocationRelRelationshipCollection PhysicalLocationRel { get; set; } = new PhysicalAssetActualPhysicalLocationRelRelationshipCollection();

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