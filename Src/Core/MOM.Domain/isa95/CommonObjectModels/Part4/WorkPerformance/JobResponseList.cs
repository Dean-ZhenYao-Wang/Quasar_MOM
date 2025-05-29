namespace MOM.Domain.isa95.CommonObjectModels.Part4.WorkPerformance
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.JobResponseList;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class JobResponseList : BaseEntity, IEquatable<JobResponseList>
    {
        public JobResponseList()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:JobResponseList;1";

        [JsonPropertyName("version")]
        public string? Version { get; set; }

        [JsonPropertyName("workType")]
        public JobResponseListWorkType? WorkType { get; set; }

        [JsonPropertyName("startTime")]
        public DateTime? StartTime { get; set; }

        [JsonPropertyName("endTime")]
        public DateTime? EndTime { get; set; }

        [JsonPropertyName("hierarchyScope")]
        public string? HierarchyScope { get; set; }

        [JsonIgnore]
public virtual List<JobResponseListIsMadeUpOfRelationship> IsMadeUpOf { get; set; } = new List<JobResponseListIsMadeUpOfRelationship>();

        [JsonIgnore]
public virtual List<JobResponseListHierarchyScopeRelRelationship> HierarchyScopeRel { get; set; } = new List<JobResponseListHierarchyScopeRelRelationship>();

        public override bool Equals(object? obj)
        {
            return Equals(obj as JobResponseList);
        }

        public bool Equals(JobResponseList? other)
        {
            return other is not null && base.Equals(other) && Version == other.Version && WorkType == other.WorkType && StartTime == other.StartTime && EndTime == other.EndTime && HierarchyScope == other.HierarchyScope;
        }

        public static bool operator ==(JobResponseList? left, JobResponseList? right)
        {
            return EqualityComparer<JobResponseList?>.Default.Equals(left, right);
        }

        public static bool operator !=(JobResponseList? left, JobResponseList? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Version?.GetHashCode(), WorkType?.GetHashCode(), StartTime?.GetHashCode(), EndTime?.GetHashCode(), HierarchyScope?.GetHashCode());
        }
    }
}