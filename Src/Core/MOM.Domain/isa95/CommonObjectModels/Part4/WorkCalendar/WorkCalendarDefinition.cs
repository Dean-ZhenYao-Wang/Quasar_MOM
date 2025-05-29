namespace MOM.Domain.isa95.CommonObjectModels.Part4.WorkCalendar
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.WorkCalendarDefinition;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text.Json.Serialization;

    public partial class WorkCalendarDefinition : BaseEntity, IEquatable<WorkCalendarDefinition>
    {
        public WorkCalendarDefinition()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:WorkCalendarDefinition;1";

        [JsonPropertyName("hierarchyScope")]
        public string? HierarchyScope { get; set; }

        [JsonIgnore]
public virtual List<WorkCalendarDefinitionContainsRelationship> Contains { get; set; } = new List<WorkCalendarDefinitionContainsRelationship>();

        [JsonIgnore]
public virtual List<WorkCalendarDefinitionHasPropertiesOfRelationship> HasPropertiesOf { get; set; } = new List<WorkCalendarDefinitionHasPropertiesOfRelationship>();

        [MaxLength(1)]
        [JsonIgnore]
public virtual List<WorkCalendarDefinitionHierarchyScopeRelRelationship> HierarchyScopeRel { get; set; } = new List<WorkCalendarDefinitionHierarchyScopeRelRelationship>();

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkCalendarDefinition);
        }

        public bool Equals(WorkCalendarDefinition? other)
        {
            return other is not null && base.Equals(other) && HierarchyScope == other.HierarchyScope;
        }

        public static bool operator ==(WorkCalendarDefinition? left, WorkCalendarDefinition? right)
        {
            return EqualityComparer<WorkCalendarDefinition?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkCalendarDefinition? left, WorkCalendarDefinition? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), HierarchyScope?.GetHashCode());
        }

        public void ContainsOfAddTarget(WorkCalendarDefinitionEntry workCalendarDefinitionEntry)
        {
            this.Contains.Add(new WorkCalendarDefinitionContainsRelationship(this, workCalendarDefinitionEntry));
        }
    }
}