namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationsSchedule
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.OperationsSchedule;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class OperationsSchedule : BaseEntity, IEquatable<OperationsSchedule>
    {
        public OperationsSchedule()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:OperationsSchedule;1";

        [JsonPropertyName("operationsType")]
        public OperationsScheduleOperationsType? OperationsType { get; set; }

        [JsonPropertyName("startTime")]
        public DateTime? StartTime { get; set; }

        [JsonPropertyName("endTime")]
        public DateTime? EndTime { get; set; }

        [JsonPropertyName("publishedDate")]
        public DateTime? PublishedDate { get; set; }

        [JsonPropertyName("hierarchyScope")]
        public string? HierarchyScope { get; set; }

        [JsonPropertyName("scheduleState")]
        public OperationsScheduleScheduleState? ScheduleState { get; set; }

        [JsonIgnore]
        public virtual OperationsScheduleIsMadeUpOfRelationshipCollection IsMadeUpOf { get; set; } = new OperationsScheduleIsMadeUpOfRelationshipCollection();

        [JsonIgnore]
        public virtual OperationsScheduleHierarchyScopeRelRelationshipCollection HierarchyScopeRel { get; set; } = new OperationsScheduleHierarchyScopeRelRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsSchedule);
        }

        public bool Equals(OperationsSchedule? other)
        {
            return other is not null && base.Equals(other) && OperationsType == other.OperationsType && StartTime == other.StartTime && EndTime == other.EndTime && PublishedDate == other.PublishedDate && HierarchyScope == other.HierarchyScope && ScheduleState == other.ScheduleState;
        }

        public static bool operator ==(OperationsSchedule? left, OperationsSchedule? right)
        {
            return EqualityComparer<OperationsSchedule?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsSchedule? left, OperationsSchedule? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), OperationsType?.GetHashCode(), StartTime?.GetHashCode(), EndTime?.GetHashCode(), PublishedDate?.GetHashCode(), HierarchyScope?.GetHashCode(), ScheduleState?.GetHashCode());
        }
    }
}