namespace MOM.Domain.isa95.CommonObjectModels.Part4.WorkPerformance
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.WorkResponse;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class WorkResponse : BaseEntity, IEquatable<WorkResponse>
    {
        public WorkResponse()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:WorkResponse;1";

        [JsonPropertyName("workType")]
        public WorkResponseWorkType? WorkType { get; set; }

        [JsonPropertyName("startTime")]
        public DateTime? StartTime { get; set; }

        [JsonPropertyName("endTime")]
        public DateTime? EndTime { get; set; }

        [JsonPropertyName("hierarchyScope")]
        public string? HierarchyScope { get; set; }

        [JsonPropertyName("responseState")]
        public WorkResponseResponseState? ResponseState { get; set; }

        [JsonIgnore]
public virtual List<WorkResponseIsMadeUpOfResponseRelationship> IsMadeUpOfResponse { get; set; } = new List<WorkResponseIsMadeUpOfResponseRelationship>();

        [JsonIgnore]
public virtual List<WorkResponseIsMadeUpOfJobRelationship> IsMadeUpOfJob { get; set; } = new List<WorkResponseIsMadeUpOfJobRelationship>();

        [JsonIgnore]
public virtual List<WorkResponseCorrespondsToRelationship> CorrespondsTo { get; set; } = new List<WorkResponseCorrespondsToRelationship>();

        [JsonIgnore]
public virtual List<WorkResponseHierarchyScopeRelRelationship> HierarchyScopeRel { get; set; } = new List<WorkResponseHierarchyScopeRelRelationship>();

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkResponse);
        }

        public bool Equals(WorkResponse? other)
        {
            return other is not null && base.Equals(other) && WorkType == other.WorkType && StartTime == other.StartTime && EndTime == other.EndTime && HierarchyScope == other.HierarchyScope && ResponseState == other.ResponseState;
        }

        public static bool operator ==(WorkResponse? left, WorkResponse? right)
        {
            return EqualityComparer<WorkResponse?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkResponse? left, WorkResponse? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), WorkType?.GetHashCode(), StartTime?.GetHashCode(), EndTime?.GetHashCode(), HierarchyScope?.GetHashCode(), ResponseState?.GetHashCode());
        }
    }
}