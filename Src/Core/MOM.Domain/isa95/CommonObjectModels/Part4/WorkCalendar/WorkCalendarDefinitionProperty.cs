namespace MOM.Domain.isa95.CommonObjectModels.Part4.WorkCalendar
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.WorkCalendarDefinitionProperty;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public partial class WorkCalendarDefinitionProperty : BaseEntity, IEquatable<WorkCalendarDefinitionProperty>
    {
        public WorkCalendarDefinitionProperty()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:WorkCalendarDefinitionProperty;1";

        [JsonPropertyName("value")]
        public string? Value { get; set; }

        [JsonPropertyName("valueUnitOfMeasure")]
        public string? ValueUnitOfMeasure { get; set; }

        [JsonIgnore]
        public virtual WorkCalendarDefinitionPropertyContainsRelationshipCollection Contains { get; set; } = new WorkCalendarDefinitionPropertyContainsRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkCalendarDefinitionProperty);
        }

        public bool Equals(WorkCalendarDefinitionProperty? other)
        {
            return other is not null && base.Equals(other) && Value == other.Value && ValueUnitOfMeasure == other.ValueUnitOfMeasure;
        }

        public static bool operator ==(WorkCalendarDefinitionProperty? left, WorkCalendarDefinitionProperty? right)
        {
            return EqualityComparer<WorkCalendarDefinitionProperty?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkCalendarDefinitionProperty? left, WorkCalendarDefinitionProperty? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Value?.GetHashCode(), ValueUnitOfMeasure?.GetHashCode());
        }
    }
}