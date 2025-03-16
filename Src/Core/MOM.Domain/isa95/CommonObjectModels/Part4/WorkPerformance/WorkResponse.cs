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
        public virtual WorkResponseIsMadeUpOfResponseRelationshipCollection IsMadeUpOfResponse { get; set; } = new WorkResponseIsMadeUpOfResponseRelationshipCollection();

        [JsonIgnore]
        public virtual WorkResponseIsMadeUpOfJobRelationshipCollection IsMadeUpOfJob { get; set; } = new WorkResponseIsMadeUpOfJobRelationshipCollection();

        [JsonIgnore]
        public virtual WorkResponseCorrespondsToRelationshipCollection CorrespondsTo { get; set; } = new WorkResponseCorrespondsToRelationshipCollection();

        [JsonIgnore]
        public virtual WorkResponseHierarchyScopeRelRelationshipCollection HierarchyScopeRel { get; set; } = new WorkResponseHierarchyScopeRelRelationshipCollection();

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