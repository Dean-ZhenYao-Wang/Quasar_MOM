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
        public virtual JobResponseCorrespondsToWorkMasterRelationshipCollection CorrespondsToWorkMaster { get; set; } = new JobResponseCorrespondsToWorkMasterRelationshipCollection();

        [JsonIgnore]
        public virtual JobResponseCorrespondsToWorkDirectiveRelationshipCollection CorrespondsToWorkDirective { get; set; } = new JobResponseCorrespondsToWorkDirectiveRelationshipCollection();

        [JsonIgnore]
        public virtual JobResponseCorrespondsToSpecificationRelationshipCollection CorrespondsToSpecification { get; set; } = new JobResponseCorrespondsToSpecificationRelationshipCollection();

        [JsonIgnore]
        public virtual JobResponseCorrespondsToSpecificationNodeRelationshipCollection CorrespondsToSpecificationNode { get; set; } = new JobResponseCorrespondsToSpecificationNodeRelationshipCollection();

        [JsonIgnore]
        public virtual JobResponseCorrespondsToJobOrderRelationshipCollection CorrespondsToJobOrder { get; set; } = new JobResponseCorrespondsToJobOrderRelationshipCollection();

        [JsonIgnore]
        public virtual JobResponseContainsDataRelationshipCollection ContainsData { get; set; } = new JobResponseContainsDataRelationshipCollection();

        [JsonIgnore]
        public virtual JobResponseContainsPersonnelRelationshipCollection ContainsPersonnel { get; set; } = new JobResponseContainsPersonnelRelationshipCollection();

        [JsonIgnore]
        public virtual JobResponseContainsEquipmentRelationshipCollection ContainsEquipment { get; set; } = new JobResponseContainsEquipmentRelationshipCollection();

        [JsonIgnore]
        public virtual JobResponseContainsPhysicalAssetRelationshipCollection ContainsPhysicalAsset { get; set; } = new JobResponseContainsPhysicalAssetRelationshipCollection();

        [JsonIgnore]
        public virtual JobResponseContainsMaterialRelationshipCollection ContainsMaterial { get; set; } = new JobResponseContainsMaterialRelationshipCollection();

        [JsonIgnore]
        public virtual JobResponseHierarchyScopeRelRelationshipCollection HierarchyScopeRel { get; set; } = new JobResponseHierarchyScopeRelRelationshipCollection();

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