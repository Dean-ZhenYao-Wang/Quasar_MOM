namespace MOM.Domain.isa95.CommonObjectModels.Part4.WorkAlert
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.WorkAlert;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class WorkAlert : BaseEntity, IEquatable<WorkAlert>
    {
        public WorkAlert()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:WorkAlert;1";

        [JsonPropertyName("timestamp")]
        public DateTime? Timestamp { get; set; }

        [JsonPropertyName("hierarchyScope")]
        public string? HierarchyScope { get; set; }

        [JsonPropertyName("priority")]
        public string? Priority { get; set; }

        [JsonPropertyName("category")]
        public string? Category { get; set; }

        [JsonIgnore]
public virtual List<WorkAlertDefinedByRelationship> DefinedBy { get; set; } = new List<WorkAlertDefinedByRelationship>();

        [JsonIgnore]
public virtual List<WorkAlertHasValuesOfRelationship> HasValuesOf { get; set; } = new List<WorkAlertHasValuesOfRelationship>();

        [JsonIgnore]
public virtual List<WorkAlertHierarchyScopeRelRelationship> HierarchyScopeRel { get; set; } = new List<WorkAlertHierarchyScopeRelRelationship>();

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkAlert);
        }

        public bool Equals(WorkAlert? other)
        {
            return other is not null && base.Equals(other) && Timestamp == other.Timestamp && HierarchyScope == other.HierarchyScope && Priority == other.Priority && Category == other.Category;
        }

        public static bool operator ==(WorkAlert? left, WorkAlert? right)
        {
            return EqualityComparer<WorkAlert?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkAlert? left, WorkAlert? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Timestamp?.GetHashCode(), HierarchyScope?.GetHashCode(), Priority?.GetHashCode(), Category?.GetHashCode());
        }
    }
}