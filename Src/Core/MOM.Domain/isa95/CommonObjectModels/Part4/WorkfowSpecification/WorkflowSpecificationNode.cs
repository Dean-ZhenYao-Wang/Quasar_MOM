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
        public virtual WorkflowSpecificationNodeContainsRelationshipCollection Contains { get; set; } = new WorkflowSpecificationNodeContainsRelationshipCollection();

        [JsonIgnore]
        public virtual WorkflowSpecificationNodeIncludesPropertiesOfRelationshipCollection IncludesPropertiesOf { get; set; } = new WorkflowSpecificationNodeIncludesPropertiesOfRelationshipCollection();

        [JsonIgnore]
        public virtual WorkflowSpecificationNodeCorrespondsToWorkMasterRelationshipCollection CorrespondsToWorkMaster { get; set; } = new WorkflowSpecificationNodeCorrespondsToWorkMasterRelationshipCollection();

        [JsonIgnore]
        public virtual WorkflowSpecificationNodeCorrespondsToWorkDirectiveRelationshipCollection CorrespondsToWorkDirective { get; set; } = new WorkflowSpecificationNodeCorrespondsToWorkDirectiveRelationshipCollection();

        [JsonIgnore]
        public virtual WorkflowSpecificationNodeDefinedByRelationshipCollection DefinedBy { get; set; } = new WorkflowSpecificationNodeDefinedByRelationshipCollection();

        [JsonIgnore]
        public virtual WorkflowSpecificationNodeHasPropertiesOfRelationshipCollection HasPropertiesOf { get; set; } = new WorkflowSpecificationNodeHasPropertiesOfRelationshipCollection();

        [JsonIgnore]
        public virtual WorkflowSpecificationNodeHierarchyScopeRelRelationshipCollection HierarchyScopeRel { get; set; } = new WorkflowSpecificationNodeHierarchyScopeRelRelationshipCollection();

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