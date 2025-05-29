namespace MOM.Domain.isa95.CommonObjectModels.Part4.WorkPerformance
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.WorkPerformance;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class WorkPerformance : BaseEntity, IEquatable<WorkPerformance>
    {
        public WorkPerformance()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:WorkPerformance;1";

        [JsonPropertyName("hierarchyScope")]
        public string? HierarchyScope { get; set; }

        [JsonPropertyName("workType")]
        public WorkPerformanceWorkType? WorkType { get; set; }

        [JsonPropertyName("startTime")]
        public DateTime? StartTime { get; set; }

        [JsonPropertyName("endTime")]
        public DateTime? EndTime { get; set; }

        [JsonPropertyName("publishedDate")]
        public DateTime? PublishedDate { get; set; }

        [JsonPropertyName("workState")]
        public WorkPerformanceWorkState? WorkState { get; set; }

        [JsonIgnore]
public virtual List<WorkPerformanceIsMadeUpOfPerformanceRelationship> IsMadeUpOfPerformance { get; set; } = new List<WorkPerformanceIsMadeUpOfPerformanceRelationship>();

        [JsonIgnore]
public virtual List<WorkPerformanceIsMadeUpOfResponseRelationship> IsMadeUpOfResponse { get; set; } = new List<WorkPerformanceIsMadeUpOfResponseRelationship>();

        [JsonIgnore]
public virtual List<WorkPerformanceCorrespondsToRelationship> CorrespondsTo { get; set; } = new List<WorkPerformanceCorrespondsToRelationship>();

        [JsonIgnore]
public virtual List<WorkPerformanceHierarchyScopeRelRelationship> HierarchyScopeRel { get; set; } = new List<WorkPerformanceHierarchyScopeRelRelationship>();

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkPerformance);
        }

        public bool Equals(WorkPerformance? other)
        {
            return other is not null && base.Equals(other) && HierarchyScope == other.HierarchyScope && WorkType == other.WorkType && StartTime == other.StartTime && EndTime == other.EndTime && PublishedDate == other.PublishedDate && WorkState == other.WorkState;
        }

        public static bool operator ==(WorkPerformance? left, WorkPerformance? right)
        {
            return EqualityComparer<WorkPerformance?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkPerformance? left, WorkPerformance? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), HierarchyScope?.GetHashCode(), WorkType?.GetHashCode(), StartTime?.GetHashCode(), EndTime?.GetHashCode(), PublishedDate?.GetHashCode(), WorkState?.GetHashCode());
        }
    }
}