namespace MOM.Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.WorkflowSpecificationNode;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class WorkflowSpecificationNode : BaseEntity, IEquatable<WorkflowSpecificationNode>
    {
        public WorkflowSpecificationNode()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:WorkflowSpecificationNode;1";

        [JsonPropertyName("hierarchyScope")]
        public string? HierarchyScope { get; set; }

        [JsonIgnore]
public virtual List<WorkflowSpecificationNodeContainsRelationship> Contains { get; set; } = new List<WorkflowSpecificationNodeContainsRelationship>();

        [JsonIgnore]
public virtual List<WorkflowSpecificationNodeIncludesPropertiesOfRelationship> IncludesPropertiesOf { get; set; } = new List<WorkflowSpecificationNodeIncludesPropertiesOfRelationship>();

        [JsonIgnore]
public virtual List<WorkflowSpecificationNodeCorrespondsToWorkMasterRelationship> CorrespondsToWorkMaster { get; set; } = new List<WorkflowSpecificationNodeCorrespondsToWorkMasterRelationship>();

        [JsonIgnore]
public virtual List<WorkflowSpecificationNodeCorrespondsToWorkDirectiveRelationship> CorrespondsToWorkDirective { get; set; } = new List<WorkflowSpecificationNodeCorrespondsToWorkDirectiveRelationship>();

        [JsonIgnore]
public virtual List<WorkflowSpecificationNodeDefinedByRelationship> DefinedBy { get; set; } = new List<WorkflowSpecificationNodeDefinedByRelationship>();

        [JsonIgnore]
public virtual List<WorkflowSpecificationNodeHasPropertiesOfRelationship> HasPropertiesOf { get; set; } = new List<WorkflowSpecificationNodeHasPropertiesOfRelationship>();

        [JsonIgnore]
public virtual List<WorkflowSpecificationNodeHierarchyScopeRelRelationship> HierarchyScopeRel { get; set; } = new List<WorkflowSpecificationNodeHierarchyScopeRelRelationship>();

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkflowSpecificationNode);
        }

        public bool Equals(WorkflowSpecificationNode? other)
        {
            return other is not null && base.Equals(other) && HierarchyScope == other.HierarchyScope;
        }

        public static bool operator ==(WorkflowSpecificationNode? left, WorkflowSpecificationNode? right)
        {
            return EqualityComparer<WorkflowSpecificationNode?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkflowSpecificationNode? left, WorkflowSpecificationNode? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), HierarchyScope?.GetHashCode());
        }
    }
}