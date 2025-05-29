namespace MOM.Domain.isa95.CommonObjectModels.Part4.WorkCalendar
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.WorkCalendarEntry;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public partial class WorkCalendarEntry : BaseEntity, IEquatable<WorkCalendarEntry>
    {
        public WorkCalendarEntry()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:WorkCalendarEntry;1";

        [JsonPropertyName("startTime")]
        public DateTime? StartTime { get; set; }

        [JsonPropertyName("endTime")]
        public DateTime? EndTime { get; set; }

        [JsonPropertyName("entryType")]
        public string? EntryType { get; set; }

        [JsonIgnore]
public virtual List<WorkCalendarEntryMapsToRelationship> MapsTo { get; set; } = new List<WorkCalendarEntryMapsToRelationship>();

        [JsonIgnore]
public virtual List<WorkCalendarEntryIsMadeUpOfRelationship> IsMadeUpOf { get; set; } = new List<WorkCalendarEntryIsMadeUpOfRelationship>();

        [JsonIgnore]
public virtual List<WorkCalendarEntryHasValuesOfRelationship> HasValuesOf { get; set; } = new List<WorkCalendarEntryHasValuesOfRelationship>();

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkCalendarEntry);
        }

        public bool Equals(WorkCalendarEntry? other)
        {
            return other is not null && base.Equals(other) && StartTime == other.StartTime && EndTime == other.EndTime && EntryType == other.EntryType;
        }

        public static bool operator ==(WorkCalendarEntry? left, WorkCalendarEntry? right)
        {
            return EqualityComparer<WorkCalendarEntry?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkCalendarEntry? left, WorkCalendarEntry? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), StartTime?.GetHashCode(), EndTime?.GetHashCode(), EntryType?.GetHashCode());
        }
    }
}