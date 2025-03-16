namespace MOM.Domain.isa95.CommonObjectModels.Part4.WorkCapability
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.WorkMasterCapability;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class WorkMasterCapability : BaseEntity, IEquatable<WorkMasterCapability>
    {
        public WorkMasterCapability()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:WorkMasterCapability;1";

        [JsonPropertyName("operationsType")]
        public WorkMasterCapabilityOperationsType? OperationsType { get; set; }

        [JsonPropertyName("workMasterID")]
        public string? WorkMasterID { get; set; }

        [JsonPropertyName("capabilityType")]
        public WorkMasterCapabilityCapabilityType? CapabilityType { get; set; }

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
        public virtual WorkMasterCapabilityCorrespondsToRelationshipCollection CorrespondsTo { get; set; } = new WorkMasterCapabilityCorrespondsToRelationshipCollection();

        [JsonIgnore]
        public virtual WorkMasterCapabilityIsMadeUpOfRelationshipCollection IsMadeUpOf { get; set; } = new WorkMasterCapabilityIsMadeUpOfRelationshipCollection();

        [JsonIgnore]
        public virtual WorkMasterCapabilityIsACollectionOfPersonnelRelationshipCollection IsACollectionOfPersonnel { get; set; } = new WorkMasterCapabilityIsACollectionOfPersonnelRelationshipCollection();

        [JsonIgnore]
        public virtual WorkMasterCapabilityIsACollectionOfEquipmentRelationshipCollection IsACollectionOfEquipment { get; set; } = new WorkMasterCapabilityIsACollectionOfEquipmentRelationshipCollection();

        [JsonIgnore]
        public virtual WorkMasterCapabilityIsACollectionOfPhysicalAssetRelationshipCollection IsACollectionOfPhysicalAsset { get; set; } = new WorkMasterCapabilityIsACollectionOfPhysicalAssetRelationshipCollection();

        [JsonIgnore]
        public virtual WorkMasterCapabilityIsACollectionOfMaterialRelationshipCollection IsACollectionOfMaterial { get; set; } = new WorkMasterCapabilityIsACollectionOfMaterialRelationshipCollection();

        [JsonIgnore]
        public virtual WorkMasterCapabilityHierarchyScopeRelRelationshipCollection HierarchyScopeRel { get; set; } = new WorkMasterCapabilityHierarchyScopeRelRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkMasterCapability);
        }

        public bool Equals(WorkMasterCapability? other)
        {
            return other is not null && base.Equals(other) && OperationsType == other.OperationsType && WorkMasterID == other.WorkMasterID && CapabilityType == other.CapabilityType && Reason == other.Reason && ConfidenceFactor == other.ConfidenceFactor && StartTime == other.StartTime && EndTime == other.EndTime && PublishedDate == other.PublishedDate && HierarchyScope == other.HierarchyScope;
        }

        public static bool operator ==(WorkMasterCapability? left, WorkMasterCapability? right)
        {
            return EqualityComparer<WorkMasterCapability?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkMasterCapability? left, WorkMasterCapability? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), OperationsType?.GetHashCode(), WorkMasterID?.GetHashCode(), CapabilityType?.GetHashCode(), Reason?.GetHashCode(), ConfidenceFactor?.GetHashCode(), StartTime?.GetHashCode(), EndTime?.GetHashCode(), PublishedDate?.GetHashCode(), HierarchyScope?.GetHashCode());
        }
    }
}