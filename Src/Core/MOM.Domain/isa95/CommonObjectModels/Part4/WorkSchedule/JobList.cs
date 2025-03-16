namespace MOM.Domain.isa95.CommonObjectModels.Part4.WorkSchedule
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.JobList;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class JobList : BaseEntity, IEquatable<JobList>
    {
        public JobList()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:JobList;1";

        [JsonPropertyName("hierarchyScope")]
        public string? HierarchyScope { get; set; }

        [JsonPropertyName("workType")]
        public JobListWorkType? WorkType { get; set; }

        [JsonPropertyName("startTime")]
        public DateTime? StartTime { get; set; }

        [JsonPropertyName("endTime")]
        public DateTime? EndTime { get; set; }

        [JsonPropertyName("publishedDate")]
        public DateTime? PublishedDate { get; set; }

        [JsonIgnore]
        public virtual JobListIsMadeUpOfRelationshipCollection IsMadeUpOf { get; set; } = new JobListIsMadeUpOfRelationshipCollection();

        [JsonIgnore]
        public virtual JobListHierarchyScopeRelRelationshipCollection HierarchyScopeRel { get; set; } = new JobListHierarchyScopeRelRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as JobList);
        }

        public bool Equals(JobList? other)
        {
            return other is not null && base.Equals(other) && HierarchyScope == other.HierarchyScope && WorkType == other.WorkType && StartTime == other.StartTime && EndTime == other.EndTime && PublishedDate == other.PublishedDate;
        }

        public static bool operator ==(JobList? left, JobList? right)
        {
            return EqualityComparer<JobList?>.Default.Equals(left, right);
        }

        public static bool operator !=(JobList? left, JobList? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), HierarchyScope?.GetHashCode(), WorkType?.GetHashCode(), StartTime?.GetHashCode(), EndTime?.GetHashCode(), PublishedDate?.GetHashCode());
        }
    }
}