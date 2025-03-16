namespace MOM.Domain.isa95.CommonObjectModels.Part4.WorkCalendar
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.WorkCalendarProperty;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public partial class WorkCalendarProperty : BaseEntity, IEquatable<WorkCalendarProperty>
    {
        public WorkCalendarProperty()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:WorkCalendarProperty;1";

        [JsonPropertyName("value")]
        public string? Value { get; set; }

        [JsonPropertyName("valueUnitOfMeasure")]
        public string? ValueUnitOfMeasure { get; set; }

        [JsonIgnore]
        public virtual WorkCalendarPropertyContainsRelationshipCollection Contains { get; set; } = new WorkCalendarPropertyContainsRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkCalendarProperty);
        }

        public bool Equals(WorkCalendarProperty? other)
        {
            return other is not null && base.Equals(other) && Value == other.Value && ValueUnitOfMeasure == other.ValueUnitOfMeasure;
        }

        public static bool operator ==(WorkCalendarProperty? left, WorkCalendarProperty? right)
        {
            return EqualityComparer<WorkCalendarProperty?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkCalendarProperty? left, WorkCalendarProperty? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Value?.GetHashCode(), ValueUnitOfMeasure?.GetHashCode());
        }
    }
}