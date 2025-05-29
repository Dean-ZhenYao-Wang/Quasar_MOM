namespace MOM.Domain.isa95.CommonObjectModels.Part4.WorkCalendar
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.WorkCalendarDefinitionEntry;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public partial class WorkCalendarDefinitionEntry : BaseEntity, IEquatable<WorkCalendarDefinitionEntry>
    {
        public WorkCalendarDefinitionEntry()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:WorkCalendarDefinitionEntry;1";

        [JsonPropertyName("startRule")]
        public string StartRule { get; set; }

        [JsonPropertyName("recurrenceTimeIntervalRule")]
        public string RecurrenceTimeIntervalRule { get; set; }

        [JsonPropertyName("durationRule")]
        public string DurationRule { get; set; }

        [JsonPropertyName("entryType")]
        public string EntryType { get; set; }

        [JsonIgnore]
public virtual List<WorkCalendarDefinitionEntryIsMadeUpOfRelationship> IsMadeUpOf { get; set; } = new List<WorkCalendarDefinitionEntryIsMadeUpOfRelationship>();

        [JsonIgnore]
public virtual List<WorkCalendarDefinitionEntryHasPropertiesOfRelationship> HasPropertiesOf { get; set; } = new List<WorkCalendarDefinitionEntryHasPropertiesOfRelationship>();

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkCalendarDefinitionEntry);
        }

        public bool Equals(WorkCalendarDefinitionEntry? other)
        {
            return other is not null && base.Equals(other) && StartRule == other.StartRule && RecurrenceTimeIntervalRule == other.RecurrenceTimeIntervalRule && DurationRule == other.DurationRule && EntryType == other.EntryType;
        }

        public static bool operator ==(WorkCalendarDefinitionEntry? left, WorkCalendarDefinitionEntry? right)
        {
            return EqualityComparer<WorkCalendarDefinitionEntry?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkCalendarDefinitionEntry? left, WorkCalendarDefinitionEntry? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), StartRule?.GetHashCode(), RecurrenceTimeIntervalRule?.GetHashCode(), DurationRule?.GetHashCode(), EntryType?.GetHashCode());
        }
    }
}