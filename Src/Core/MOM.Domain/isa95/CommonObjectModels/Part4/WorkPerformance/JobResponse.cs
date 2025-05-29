namespace MOM.Domain.isa95.CommonObjectModels.Part4.WorkPerformance
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.JobResponse;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class JobResponse : BaseEntity, IEquatable<JobResponse>
    {
        public JobResponse()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:JobResponse;1";

        [JsonPropertyName("workType")]
        public JobResponseWorkType? WorkType { get; set; }

        [JsonPropertyName("jobOrder")]
        public string? JobOrder { get; set; }

        [JsonPropertyName("startTime")]
        public DateTime? StartTime { get; set; }

        [JsonPropertyName("endTime")]
        public DateTime? EndTime { get; set; }

        [JsonPropertyName("hierarchyScope")]
        public string? HierarchyScope { get; set; }

        [JsonPropertyName("jobState")]
        public JobResponseJobState? JobState { get; set; }

        [JsonIgnore]
public virtual List<JobResponseCorrespondsToWorkMasterRelationship> CorrespondsToWorkMaster { get; set; } = new List<JobResponseCorrespondsToWorkMasterRelationship>();

        [JsonIgnore]
public virtual List<JobResponseCorrespondsToWorkDirectiveRelationship> CorrespondsToWorkDirective { get; set; } = new List<JobResponseCorrespondsToWorkDirectiveRelationship>();

        [JsonIgnore]
public virtual List<JobResponseCorrespondsToSpecificationRelationship> CorrespondsToSpecification { get; set; } = new List<JobResponseCorrespondsToSpecificationRelationship>();

        [JsonIgnore]
public virtual List<JobResponseCorrespondsToSpecificationNodeRelationship> CorrespondsToSpecificationNode { get; set; } = new List<JobResponseCorrespondsToSpecificationNodeRelationship>();

        [JsonIgnore]
public virtual List<JobResponseCorrespondsToJobOrderRelationship> CorrespondsToJobOrder { get; set; } = new List<JobResponseCorrespondsToJobOrderRelationship>();

        [JsonIgnore]
public virtual List<JobResponseContainsDataRelationship> ContainsData { get; set; } = new List<JobResponseContainsDataRelationship>();

        [JsonIgnore]
public virtual List<JobResponseContainsPersonnelRelationship> ContainsPersonnel { get; set; } = new List<JobResponseContainsPersonnelRelationship>();

        [JsonIgnore]
public virtual List<JobResponseContainsEquipmentRelationship> ContainsEquipment { get; set; } = new List<JobResponseContainsEquipmentRelationship>();

        [JsonIgnore]
public virtual List<JobResponseContainsPhysicalAssetRelationship> ContainsPhysicalAsset { get; set; } = new List<JobResponseContainsPhysicalAssetRelationship>();

        [JsonIgnore]
public virtual List<JobResponseContainsMaterialRelationship> ContainsMaterial { get; set; } = new List<JobResponseContainsMaterialRelationship>();

        [JsonIgnore]
public virtual List<JobResponseHierarchyScopeRelRelationship> HierarchyScopeRel { get; set; } = new List<JobResponseHierarchyScopeRelRelationship>();

        public override bool Equals(object? obj)
        {
            return Equals(obj as JobResponse);
        }

        public bool Equals(JobResponse? other)
        {
            return other is not null && base.Equals(other) && WorkType == other.WorkType && JobOrder == other.JobOrder && StartTime == other.StartTime && EndTime == other.EndTime && HierarchyScope == other.HierarchyScope && JobState == other.JobState;
        }

        public static bool operator ==(JobResponse? left, JobResponse? right)
        {
            return EqualityComparer<JobResponse?>.Default.Equals(left, right);
        }

        public static bool operator !=(JobResponse? left, JobResponse? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), WorkType?.GetHashCode(), JobOrder?.GetHashCode(), StartTime?.GetHashCode(), EndTime?.GetHashCode(), HierarchyScope?.GetHashCode(), JobState?.GetHashCode());
        }
    }
}