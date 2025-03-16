namespace MOM.Domain.isa95.CommonObjectModels.Part4.WorkCalendar
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.WorkCalendar;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text.Json.Serialization;

    public partial class WorkCalendar : BaseEntity, IEquatable<WorkCalendar>
    {
        public WorkCalendar()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:WorkCalendar;1";

        [JsonPropertyName("hierarchyScope")]
        public string? HierarchyScope { get; set; }
        [MaxLength(1)]
        [JsonIgnore]
        public virtual WorkCalendarDefinedByRelationshipCollection DefinedBy { get; set; } = new WorkCalendarDefinedByRelationshipCollection();

        [JsonIgnore]
        public virtual WorkCalendarContainsRelationshipCollection Contains { get; set; } = new WorkCalendarContainsRelationshipCollection();

        [JsonIgnore]
        public virtual WorkCalendarHasValuesOfRelationshipCollection HasValuesOf { get; set; } = new WorkCalendarHasValuesOfRelationshipCollection();

        [JsonIgnore]
        public virtual WorkCalendarHierarchyScopeRelRelationshipCollection HierarchyScopeRel { get; set; } = new WorkCalendarHierarchyScopeRelRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkCalendar);
        }

        public bool Equals(WorkCalendar? other)
        {
            return other is not null && base.Equals(other) && HierarchyScope == other.HierarchyScope;
        }

        public static bool operator ==(WorkCalendar? left, WorkCalendar? right)
        {
            return EqualityComparer<WorkCalendar?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkCalendar? left, WorkCalendar? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), HierarchyScope?.GetHashCode());
        }
    }
}