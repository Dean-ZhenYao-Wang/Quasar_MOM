namespace MOM.Domain.isa95.CommonObjectModels.Part4.WorkCalendar
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.WorkCalendarDefinitionEntryProperty;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public partial class WorkCalendarDefinitionEntryProperty : BaseEntity, IEquatable<WorkCalendarDefinitionEntryProperty>
    {
        public WorkCalendarDefinitionEntryProperty()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:WorkCalendarDefinitionEntryProperty;1";

        [JsonPropertyName("value")]
        public string? Value { get; set; }

        [JsonPropertyName("valueUnitOfMeasure")]
        public string? ValueUnitOfMeasure { get; set; }

        [JsonIgnore]
public virtual List<WorkCalendarDefinitionEntryPropertyContainsRelationship> Contains { get; set; } = new List<WorkCalendarDefinitionEntryPropertyContainsRelationship>();

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkCalendarDefinitionEntryProperty);
        }

        public bool Equals(WorkCalendarDefinitionEntryProperty? other)
        {
            return other is not null && base.Equals(other) && Value == other.Value && ValueUnitOfMeasure == other.ValueUnitOfMeasure;
        }

        public static bool operator ==(WorkCalendarDefinitionEntryProperty? left, WorkCalendarDefinitionEntryProperty? right)
        {
            return EqualityComparer<WorkCalendarDefinitionEntryProperty?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkCalendarDefinitionEntryProperty? left, WorkCalendarDefinitionEntryProperty? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Value?.GetHashCode(), ValueUnitOfMeasure?.GetHashCode());
        }
    }
}