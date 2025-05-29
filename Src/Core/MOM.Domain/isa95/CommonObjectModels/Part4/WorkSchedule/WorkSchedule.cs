namespace MOM.Domain.isa95.CommonObjectModels.Part4.WorkSchedule
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.WorkSchedule;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class WorkSchedule : BaseEntity, IEquatable<WorkSchedule>
    {
        public WorkSchedule()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:WorkSchedule;1";

        [JsonPropertyName("hierarchyScope")]
        public string? HierarchyScope { get; set; }

        [JsonPropertyName("workType")]
        public WorkScheduleWorkType? WorkType { get; set; }

        [JsonPropertyName("startTime")]
        public DateTime? StartTime { get; set; }

        [JsonPropertyName("endTime")]
        public DateTime? EndTime { get; set; }

        [JsonPropertyName("publishedDate")]
        public DateTime? PublishedDate { get; set; }

        [JsonPropertyName("scheduleState")]
        public WorkScheduleScheduleState? ScheduleState { get; set; }

        [JsonIgnore]
public virtual List<WorkScheduleIsMadeUpOfScheduleRelationship> IsMadeUpOfSchedule { get; set; } = new List<WorkScheduleIsMadeUpOfScheduleRelationship>();

        [JsonIgnore]
public virtual List<WorkScheduleIsMadeUpOfRequestRelationship> IsMadeUpOfRequest { get; set; } = new List<WorkScheduleIsMadeUpOfRequestRelationship>();

        [JsonIgnore]
public virtual List<WorkScheduleHierarchyScopeRelRelationship> HierarchyScopeRel { get; set; } = new List<WorkScheduleHierarchyScopeRelRelationship>();

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkSchedule);
        }

        public bool Equals(WorkSchedule? other)
        {
            return other is not null && base.Equals(other) && HierarchyScope == other.HierarchyScope && WorkType == other.WorkType && StartTime == other.StartTime && EndTime == other.EndTime && PublishedDate == other.PublishedDate && ScheduleState == other.ScheduleState;
        }

        public static bool operator ==(WorkSchedule? left, WorkSchedule? right)
        {
            return EqualityComparer<WorkSchedule?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkSchedule? left, WorkSchedule? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), HierarchyScope?.GetHashCode(), WorkType?.GetHashCode(), StartTime?.GetHashCode(), EndTime?.GetHashCode(), PublishedDate?.GetHashCode(), ScheduleState?.GetHashCode());
        }
    }
}