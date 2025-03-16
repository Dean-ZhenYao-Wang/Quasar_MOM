namespace MOM.Domain.isa95.CommonObjectModels.Part4.WorkCalendar
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.WorkCalendarEntryProperty;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public partial class WorkCalendarEntryProperty : BaseEntity, IEquatable<WorkCalendarEntryProperty>
    {
        public WorkCalendarEntryProperty()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:WorkCalendarEntryProperty;1";

        [JsonPropertyName("value")]
        public string? Value { get; set; }

        [JsonPropertyName("valueUnitOfMeasure")]
        public string? ValueUnitOfMeasure { get; set; }

        [JsonIgnore]
        public virtual WorkCalendarEntryPropertyMapsToRelationshipCollection MapsTo { get; set; } = new WorkCalendarEntryPropertyMapsToRelationshipCollection();

        [JsonIgnore]
        public virtual WorkCalendarEntryPropertyContainsRelationshipCollection Contains { get; set; } = new WorkCalendarEntryPropertyContainsRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkCalendarEntryProperty);
        }

        public bool Equals(WorkCalendarEntryProperty? other)
        {
            return other is not null && base.Equals(other) && Value == other.Value && ValueUnitOfMeasure == other.ValueUnitOfMeasure;
        }

        public static bool operator ==(WorkCalendarEntryProperty? left, WorkCalendarEntryProperty? right)
        {
            return EqualityComparer<WorkCalendarEntryProperty?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkCalendarEntryProperty? left, WorkCalendarEntryProperty? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Value?.GetHashCode(), ValueUnitOfMeasure?.GetHashCode());
        }
    }
}