namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationsCapability
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.ProcessSegmentCapability;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class ProcessSegmentCapability : BaseEntity, IEquatable<ProcessSegmentCapability>
    {
        public ProcessSegmentCapability()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:ProcessSegmentCapability;1";

        [JsonPropertyName("operationsType")]
        public ProcessSegmentCapabilityOperationsType? OperationsType { get; set; }

        [JsonPropertyName("capabilityType")]
        public ProcessSegmentCapabilityCapabilityType? CapabilityType { get; set; }

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
        public virtual ProcessSegmentCapabilityCorrespondsToRelationshipCollection CorrespondsTo { get; set; } = new ProcessSegmentCapabilityCorrespondsToRelationshipCollection();

        [JsonIgnore]
        public virtual ProcessSegmentCapabilityIsMadeUpOfRelationshipCollection IsMadeUpOf { get; set; } = new ProcessSegmentCapabilityIsMadeUpOfRelationshipCollection();

        [JsonIgnore]
        public virtual ProcessSegmentCapabilityIsACollectionOfPersonnelRelationshipCollection IsACollectionOfPersonnel { get; set; } = new ProcessSegmentCapabilityIsACollectionOfPersonnelRelationshipCollection();

        [JsonIgnore]
        public virtual ProcessSegmentCapabilityIsACollectionOfEquipmentRelationshipCollection IsACollectionOfEquipment { get; set; } = new ProcessSegmentCapabilityIsACollectionOfEquipmentRelationshipCollection();

        [JsonIgnore]
        public virtual ProcessSegmentCapabilityIsACollectionOfPhysicalAssetRelationshipCollection IsACollectionOfPhysicalAsset { get; set; } = new ProcessSegmentCapabilityIsACollectionOfPhysicalAssetRelationshipCollection();

        [JsonIgnore]
        public virtual ProcessSegmentCapabilityIsACollectionOfMaterialRelationshipCollection IsACollectionOfMaterial { get; set; } = new ProcessSegmentCapabilityIsACollectionOfMaterialRelationshipCollection();

        [JsonIgnore]
        public virtual ProcessSegmentCapabilityHierarchyScopeRelRelationshipCollection HierarchyScopeRel { get; set; } = new ProcessSegmentCapabilityHierarchyScopeRelRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as ProcessSegmentCapability);
        }

        public bool Equals(ProcessSegmentCapability? other)
        {
            return other is not null && base.Equals(other) && OperationsType == other.OperationsType && CapabilityType == other.CapabilityType && Reason == other.Reason && ConfidenceFactor == other.ConfidenceFactor && StartTime == other.StartTime && EndTime == other.EndTime && HierarchyScope == other.HierarchyScope;
        }

        public static bool operator ==(ProcessSegmentCapability? left, ProcessSegmentCapability? right)
        {
            return EqualityComparer<ProcessSegmentCapability?>.Default.Equals(left, right);
        }

        public static bool operator !=(ProcessSegmentCapability? left, ProcessSegmentCapability? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), OperationsType?.GetHashCode(), CapabilityType?.GetHashCode(), Reason?.GetHashCode(), ConfidenceFactor?.GetHashCode(), StartTime?.GetHashCode(), EndTime?.GetHashCode(), HierarchyScope?.GetHashCode());
        }
    }
}