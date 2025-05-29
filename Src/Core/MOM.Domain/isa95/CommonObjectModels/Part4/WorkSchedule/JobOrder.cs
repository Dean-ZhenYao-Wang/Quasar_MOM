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
public virtual List<JobOrderCorrespondsToWorkMasterRelationship> CorrespondsToWorkMaster { get; set; } = new List<JobOrderCorrespondsToWorkMasterRelationship>();

        [JsonIgnore]
public virtual List<JobOrderCorrespondsToRequirementRelationship> CorrespondsToRequirement { get; set; } = new List<JobOrderCorrespondsToRequirementRelationship>();

        [JsonIgnore]
public virtual List<JobOrderContainsParameterRelationship> ContainsParameter { get; set; } = new List<JobOrderContainsParameterRelationship>();

        [JsonIgnore]
public virtual List<JobOrderContainsPersonnelRelationship> ContainsPersonnel { get; set; } = new List<JobOrderContainsPersonnelRelationship>();

        [JsonIgnore]
public virtual List<JobOrderContainsEquipmentRelationship> ContainsEquipment { get; set; } = new List<JobOrderContainsEquipmentRelationship>();

        [JsonIgnore]
public virtual List<JobOrderContainsPhysicalAssetRelationship> ContainsPhysicalAsset { get; set; } = new List<JobOrderContainsPhysicalAssetRelationship>();

        [JsonIgnore]
public virtual List<JobOrderContainsMaterialRelationship> ContainsMaterial { get; set; } = new List<JobOrderContainsMaterialRelationship>();

        [JsonIgnore]
public virtual List<JobOrderHierarchyScopeRelRelationship> HierarchyScopeRel { get; set; } = new List<JobOrderHierarchyScopeRelRelationship>();

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