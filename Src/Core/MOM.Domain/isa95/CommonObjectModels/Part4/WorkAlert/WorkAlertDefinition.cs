namespace MOM.Domain.isa95.CommonObjectModels.Part4.WorkAlert
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.WorkAlertDefinition;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class WorkAlertDefinition : BaseEntity, IEquatable<WorkAlertDefinition>
    {
        public WorkAlertDefinition()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:WorkAlertDefinition;1";

        [JsonPropertyName("hierarchyScope")]
        public string? HierarchyScope { get; set; }

        [JsonPropertyName("priority")]
        public string? Priority { get; set; }

        [JsonPropertyName("category")]
        public string? Category { get; set; }

        [JsonIgnore]
public virtual List<WorkAlertDefinitionHasPropertiesOfRelationship> HasPropertiesOf { get; set; } = new List<WorkAlertDefinitionHasPropertiesOfRelationship>();

        [JsonIgnore]
public virtual List<WorkAlertDefinitionHierarchyScopeRelRelationship> HierarchyScopeRel { get; set; } = new List<WorkAlertDefinitionHierarchyScopeRelRelationship>();

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkAlertDefinition);
        }

        public bool Equals(WorkAlertDefinition? other)
        {
            return other is not null && base.Equals(other) && HierarchyScope == other.HierarchyScope && Priority == other.Priority && Category == other.Category;
        }

        public static bool operator ==(WorkAlertDefinition? left, WorkAlertDefinition? right)
        {
            return EqualityComparer<WorkAlertDefinition?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkAlertDefinition? left, WorkAlertDefinition? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), HierarchyScope?.GetHashCode(), Priority?.GetHashCode(), Category?.GetHashCode());
        }
    }
}