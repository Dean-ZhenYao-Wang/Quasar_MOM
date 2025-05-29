namespace MOM.Domain.isa95.CommonObjectModels.Part4.WorkSchedule
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.WorkRequest;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class WorkRequest : BaseEntity, IEquatable<WorkRequest>
    {
        public WorkRequest()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:WorkRequest;1";

        [JsonPropertyName("hierarchyScope")]
        public string? HierarchyScope { get; set; }

        [JsonPropertyName("workType")]
        public WorkRequestWorkType? WorkType { get; set; }

        [JsonPropertyName("startTime")]
        public DateTime? StartTime { get; set; }

        [JsonPropertyName("endTime")]
        public DateTime? EndTime { get; set; }

        [JsonPropertyName("priority")]
        public string? Priority { get; set; }

        [JsonPropertyName("segmentRequirementID")]
        public string? SegmentRequirementID { get; set; }

        [JsonPropertyName("requestState")]
        public WorkRequestRequestState? RequestState { get; set; }

        [JsonIgnore]
public virtual List<WorkRequestIsMadeUpOfRequestRelationship> IsMadeUpOfRequest { get; set; } = new List<WorkRequestIsMadeUpOfRequestRelationship>();

        [JsonIgnore]
public virtual List<WorkRequestIsMadeUpOfJobRelationship> IsMadeUpOfJob { get; set; } = new List<WorkRequestIsMadeUpOfJobRelationship>();

        [JsonIgnore]
public virtual List<WorkRequestCorrespondsToRequestRelationship> CorrespondsToRequest { get; set; } = new List<WorkRequestCorrespondsToRequestRelationship>();

        [JsonIgnore]
public virtual List<WorkRequestCorrespondsToRequirementRelationship> CorrespondsToRequirement { get; set; } = new List<WorkRequestCorrespondsToRequirementRelationship>();

        [JsonIgnore]
public virtual List<WorkRequestHierarchyScopeRelRelationship> HierarchyScopeRel { get; set; } = new List<WorkRequestHierarchyScopeRelRelationship>();

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkRequest);
        }

        public bool Equals(WorkRequest? other)
        {
            return other is not null && base.Equals(other) && HierarchyScope == other.HierarchyScope && WorkType == other.WorkType && StartTime == other.StartTime && EndTime == other.EndTime && Priority == other.Priority && SegmentRequirementID == other.SegmentRequirementID && RequestState == other.RequestState;
        }

        public static bool operator ==(WorkRequest? left, WorkRequest? right)
        {
            return EqualityComparer<WorkRequest?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkRequest? left, WorkRequest? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), HierarchyScope?.GetHashCode(), WorkType?.GetHashCode(), StartTime?.GetHashCode(), EndTime?.GetHashCode(), Priority?.GetHashCode(), SegmentRequirementID?.GetHashCode(), RequestState?.GetHashCode());
        }
    }
}