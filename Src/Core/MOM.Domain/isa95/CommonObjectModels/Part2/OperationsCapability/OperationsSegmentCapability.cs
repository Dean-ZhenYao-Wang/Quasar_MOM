namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationsCapability
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.OperationsSegmentCapability;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class OperationsSegmentCapability : BaseEntity, IEquatable<OperationsSegmentCapability>
    {
        public OperationsSegmentCapability()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:OperationsSegmentCapability;1";

        [JsonPropertyName("operationsType")]
        public OperationsSegmentCapabilityOperationsType? OperationsType { get; set; }

        [JsonPropertyName("operationsSegment")]
        public string? OperationsSegment { get; set; }

        [JsonPropertyName("capabilityType")]
        public OperationsSegmentCapabilityCapabilityType? CapabilityType { get; set; }

        [JsonPropertyName("reason")]
        public string? Reason { get; set; }

        [JsonPropertyName("confidenceFactor")]
        public string? ConfidenceFactor { get; set; }

        [JsonPropertyName("startTime")]
        public DateTime? StartTime { get; set; }

        [JsonPropertyName("endTime")]
        public DateTime? EndTime { get; set; }

        [JsonPropertyName("hierarchyScope")]
        public string? HierarchyScope { get; set; }

        [JsonIgnore]
        public virtual OperationsSegmentCapabilityCorrespondsToRelationshipCollection CorrespondsTo { get; set; } = new OperationsSegmentCapabilityCorrespondsToRelationshipCollection();

        [JsonIgnore]
        public virtual OperationsSegmentCapabilityIsMadeUpOfRelationshipCollection IsMadeUpOf { get; set; } = new OperationsSegmentCapabilityIsMadeUpOfRelationshipCollection();

        [JsonIgnore]
        public virtual List<OperationsSegmentCapabilityIsACollectionOfPersonnelRelationship> IsACollectionOfPersonnel { get; set; } = new List<OperationsSegmentCapabilityIsACollectionOfPersonnelRelationship>();

        [JsonIgnore]
        public virtual List<OperationsSegmentCapabilityIsACollectionOfEquipmentRelationship> IsACollectionOfEquipment { get; set; } = new List<OperationsSegmentCapabilityIsACollectionOfEquipmentRelationship>();

        [JsonIgnore]
        public virtual List<OperationsSegmentCapabilityIsACollectionOfPhysicalAssetRelationship> IsACollectionOfPhysicalAsset { get; set; } = new List<OperationsSegmentCapabilityIsACollectionOfPhysicalAssetRelationship>();

        [JsonIgnore]
        public virtual List<OperationsSegmentCapabilityIsACollectionOfMaterialRelationship> IsACollectionOfMaterial { get; set; } = new List<OperationsSegmentCapabilityIsACollectionOfMaterialRelationship>();

        [JsonIgnore]
        public virtual OperationsSegmentCapabilityHierarchyScopeRelRelationshipCollection HierarchyScopeRel { get; set; } = new OperationsSegmentCapabilityHierarchyScopeRelRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsSegmentCapability);
        }

        public bool Equals(OperationsSegmentCapability? other)
        {
            return other is not null && base.Equals(other) && OperationsType == other.OperationsType && OperationsSegment == other.OperationsSegment && CapabilityType == other.CapabilityType && Reason == other.Reason && ConfidenceFactor == other.ConfidenceFactor && StartTime == other.StartTime && EndTime == other.EndTime && HierarchyScope == other.HierarchyScope;
        }

        public static bool operator ==(OperationsSegmentCapability? left, OperationsSegmentCapability? right)
        {
            return EqualityComparer<OperationsSegmentCapability?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsSegmentCapability? left, OperationsSegmentCapability? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), OperationsType?.GetHashCode(), OperationsSegment?.GetHashCode(), CapabilityType?.GetHashCode(), Reason?.GetHashCode(), ConfidenceFactor?.GetHashCode(), StartTime?.GetHashCode(), EndTime?.GetHashCode(), HierarchyScope?.GetHashCode());
        }
    }
}