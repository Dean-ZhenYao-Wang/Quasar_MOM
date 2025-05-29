namespace MOM.Domain.isa95.CommonObjectModels.Part4.WorkCapability
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.WorkCapability;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class WorkCapability : BaseEntity, IEquatable<WorkCapability>
    {
        public WorkCapability()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:WorkCapability;1";

        [JsonPropertyName("operationsType")]
        public WorkCapabilityOperationsType? OperationsType { get; set; }

        [JsonPropertyName("capabilityType")]
        public WorkCapabilityCapabilityType? CapabilityType { get; set; }

        [JsonPropertyName("reason")]
        public string? Reason { get; set; }

        [JsonPropertyName("confidenceFactor")]
        public string? ConfidenceFactor { get; set; }

        [JsonPropertyName("startTime")]
        public DateTime? StartTime { get; set; }

        [JsonPropertyName("endTime")]
        public DateTime? EndTime { get; set; }

        [JsonPropertyName("publishedDate")]
        public DateTime? PublishedDate { get; set; }

        [JsonPropertyName("hierarchyScope")]
        public string? HierarchyScope { get; set; }

        [JsonIgnore]
        public virtual List<WorkCapabilityIsACollectionOfWorkMasterRelationship> IsACollectionOfWorkMaster { get; set; } = new List<WorkCapabilityIsACollectionOfWorkMasterRelationship>();

        [JsonIgnore]
        public virtual List<WorkCapabilityIsACollectionOfPersonnelRelationship> IsACollectionOfPersonnel { get; set; } = new List<WorkCapabilityIsACollectionOfPersonnelRelationship>();

        [JsonIgnore]
        public virtual List<WorkCapabilityIsACollectionOfEquipmentRelationship> IsACollectionOfEquipment { get; set; } = new List<WorkCapabilityIsACollectionOfEquipmentRelationship>();

        [JsonIgnore]
        public virtual List<WorkCapabilityIsACollectionOfPhysicalAssetRelationship> IsACollectionOfPhysicalAsset { get; set; } = new List<WorkCapabilityIsACollectionOfPhysicalAssetRelationship>();

        [JsonIgnore]
        public virtual List<WorkCapabilityIsACollectionOfMaterialRelationship> IsACollectionOfMaterial { get; set; } = new List<WorkCapabilityIsACollectionOfMaterialRelationship>();

        [JsonIgnore]
        public virtual List<WorkCapabilityHierarchyScopeRelRelationship> HierarchyScopeRel { get; set; } = new List<WorkCapabilityHierarchyScopeRelRelationship>();


        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkCapability);
        }

        public bool Equals(WorkCapability? other)
        {
            return other is not null && base.Equals(other) && OperationsType == other.OperationsType && CapabilityType == other.CapabilityType && Reason == other.Reason && ConfidenceFactor == other.ConfidenceFactor && StartTime == other.StartTime && EndTime == other.EndTime && PublishedDate == other.PublishedDate && HierarchyScope == other.HierarchyScope;
        }

        public static bool operator ==(WorkCapability? left, WorkCapability? right)
        {
            return EqualityComparer<WorkCapability?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkCapability? left, WorkCapability? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), OperationsType?.GetHashCode(), CapabilityType?.GetHashCode(), Reason?.GetHashCode(), ConfidenceFactor?.GetHashCode(), StartTime?.GetHashCode(), EndTime?.GetHashCode(), PublishedDate?.GetHashCode(), HierarchyScope?.GetHashCode());
        }
    }
}