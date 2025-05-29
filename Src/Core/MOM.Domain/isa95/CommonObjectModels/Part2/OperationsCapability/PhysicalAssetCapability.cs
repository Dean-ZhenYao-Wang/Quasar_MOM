namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationsCapability
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.PhysicalAssetCapability;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class PhysicalAssetCapability : BaseEntity, IEquatable<PhysicalAssetCapability>
    {
        public PhysicalAssetCapability()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:PhysicalAssetCapability;1";

        [JsonPropertyName("capabilityType")]
        public PhysicalAssetCapabilityCapabilityType? CapabilityType { get; set; }

        [JsonPropertyName("reason")]
        public string? Reason { get; set; }

        [JsonPropertyName("confidenceFactor")]
        public string? ConfidenceFactor { get; set; }

        [JsonPropertyName("hierarchyScope")]
        public string? HierarchyScope { get; set; }

        [JsonPropertyName("physicalLocation")]
        public string? PhysicalLocation { get; set; }

        [JsonPropertyName("physicalLocationType")]
        public PhysicalAssetCapabilityPhysicalLocationType? PhysicalLocationType { get; set; }

        [JsonPropertyName("physicalAssetUse")]
        public string? PhysicalAssetUse { get; set; }

        [JsonPropertyName("startTime")]
        public DateTime? StartTime { get; set; }

        [JsonPropertyName("endTime")]
        public DateTime? EndTime { get; set; }

        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        [JsonPropertyName("quantityUnitOfMeasure")]
        public string? QuantityUnitOfMeasure { get; set; }

        [JsonIgnore]
public virtual List<PhysicalAssetCapabilityIsMadeUpOfRelationship> IsMadeUpOf { get; set; } = new List<PhysicalAssetCapabilityIsMadeUpOfRelationship>();

        [JsonIgnore]
public virtual List<PhysicalAssetCapabilityHasValuesOfRelationship> HasValuesOf { get; set; } = new List<PhysicalAssetCapabilityHasValuesOfRelationship>();

        [JsonIgnore]
public virtual List<PhysicalAssetCapabilityCorrespondsToPhysicalAssetClassRelationship> CorrespondsToPhysicalAssetClass { get; set; } = new List<PhysicalAssetCapabilityCorrespondsToPhysicalAssetClassRelationship>();

        [JsonIgnore]
public virtual List<PhysicalAssetCapabilityCorrespondsToPhysicalAssetRelationship> CorrespondsToPhysicalAsset { get; set; } = new List<PhysicalAssetCapabilityCorrespondsToPhysicalAssetRelationship>();

        [JsonIgnore]
public virtual List<PhysicalAssetCapabilityHierarchyScopeRelRelationship> HierarchyScopeRel { get; set; } = new List<PhysicalAssetCapabilityHierarchyScopeRelRelationship>();

        [JsonIgnore]
public virtual List<PhysicalAssetCapabilityPhysicalLocationRelRelationship> PhysicalLocationRel { get; set; } = new List<PhysicalAssetCapabilityPhysicalLocationRelRelationship>();

        public override bool Equals(object? obj)
        {
            return Equals(obj as PhysicalAssetCapability);
        }

        public bool Equals(PhysicalAssetCapability? other)
        {
            return other is not null && base.Equals(other) && CapabilityType == other.CapabilityType && Reason == other.Reason && ConfidenceFactor == other.ConfidenceFactor && HierarchyScope == other.HierarchyScope && PhysicalLocation == other.PhysicalLocation && PhysicalLocationType == other.PhysicalLocationType && PhysicalAssetUse == other.PhysicalAssetUse && StartTime == other.StartTime && EndTime == other.EndTime && Quantity == other.Quantity && QuantityUnitOfMeasure == other.QuantityUnitOfMeasure;
        }

        public static bool operator ==(PhysicalAssetCapability? left, PhysicalAssetCapability? right)
        {
            return EqualityComparer<PhysicalAssetCapability?>.Default.Equals(left, right);
        }

        public static bool operator !=(PhysicalAssetCapability? left, PhysicalAssetCapability? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), CapabilityType?.GetHashCode(), Reason?.GetHashCode(), ConfidenceFactor?.GetHashCode(), HierarchyScope?.GetHashCode(), PhysicalLocation?.GetHashCode(), PhysicalLocationType?.GetHashCode(), PhysicalAssetUse?.GetHashCode(), StartTime?.GetHashCode(), EndTime?.GetHashCode(), Quantity?.GetHashCode(), QuantityUnitOfMeasure?.GetHashCode());
        }
    }
}