namespace MOM.Domain.isa95.CommonObjectModels.Part4.WorkSchedule
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.JobOrder;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class JobOrder : BaseEntity, IEquatable<JobOrder>
    {
        public JobOrder()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:JobOrder;1";

        [JsonPropertyName("hierarchyScope")]
        public string? HierarchyScope { get; set; }

        [JsonPropertyName("workType")]
        public JobOrderWorkType? WorkType { get; set; }

        [JsonPropertyName("workMasterID")]
        public string? WorkMasterID { get; set; }

        [JsonPropertyName("workMasterVersion")]
        public string? WorkMasterVersion { get; set; }

        [JsonPropertyName("segmentRequirementID")]
        public string? SegmentRequirementID { get; set; }

        [JsonPropertyName("startTime")]
        public DateTime? StartTime { get; set; }

        [JsonPropertyName("endTime")]
        public DateTime? EndTime { get; set; }

        [JsonPropertyName("priority")]
        public string? Priority { get; set; }

        [JsonPropertyName("dispatchStatus")]
        public JobOrderDispatchStatus? DispatchStatus { get; set; }

        [JsonPropertyName("command")]
        public string? Command { get; set; }

        [JsonPropertyName("commandRule")]
        public string? CommandRule { get; set; }

        [JsonIgnore]
        public virtual JobOrderCorrespondsToWorkMasterRelationshipCollection CorrespondsToWorkMaster { get; set; } = new JobOrderCorrespondsToWorkMasterRelationshipCollection();

        [JsonIgnore]
        public virtual JobOrderCorrespondsToRequirementRelationshipCollection CorrespondsToRequirement { get; set; } = new JobOrderCorrespondsToRequirementRelationshipCollection();

        [JsonIgnore]
        public virtual JobOrderContainsParameterRelationshipCollection ContainsParameter { get; set; } = new JobOrderContainsParameterRelationshipCollection();

        [JsonIgnore]
        public virtual JobOrderContainsPersonnelRelationshipCollection ContainsPersonnel { get; set; } = new JobOrderContainsPersonnelRelationshipCollection();

        [JsonIgnore]
        public virtual JobOrderContainsEquipmentRelationshipCollection ContainsEquipment { get; set; } = new JobOrderContainsEquipmentRelationshipCollection();

        [JsonIgnore]
        public virtual JobOrderContainsPhysicalAssetRelationshipCollection ContainsPhysicalAsset { get; set; } = new JobOrderContainsPhysicalAssetRelationshipCollection();

        [JsonIgnore]
        public virtual JobOrderContainsMaterialRelationshipCollection ContainsMaterial { get; set; } = new JobOrderContainsMaterialRelationshipCollection();

        [JsonIgnore]
        public virtual JobOrderHierarchyScopeRelRelationshipCollection HierarchyScopeRel { get; set; } = new JobOrderHierarchyScopeRelRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as JobOrder);
        }

        public bool Equals(JobOrder? other)
        {
            return other is not null && base.Equals(other) && HierarchyScope == other.HierarchyScope && WorkType == other.WorkType && WorkMasterID == other.WorkMasterID && WorkMasterVersion == other.WorkMasterVersion && SegmentRequirementID == other.SegmentRequirementID && StartTime == other.StartTime && EndTime == other.EndTime && Priority == other.Priority && DispatchStatus == other.DispatchStatus && Command == other.Command && CommandRule == other.CommandRule;
        }

        public static bool operator ==(JobOrder? left, JobOrder? right)
        {
            return EqualityComparer<JobOrder?>.Default.Equals(left, right);
        }

        public static bool operator !=(JobOrder? left, JobOrder? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), HierarchyScope?.GetHashCode(), WorkType?.GetHashCode(), WorkMasterID?.GetHashCode(), WorkMasterVersion?.GetHashCode(), SegmentRequirementID?.GetHashCode(), StartTime?.GetHashCode(), EndTime?.GetHashCode(), Priority?.GetHashCode(), DispatchStatus?.GetHashCode(), Command?.GetHashCode(), CommandRule?.GetHashCode());
        }
    }
}