namespace MOM.Domain.Common.Relationship.isa95.WorkflowSpecificationNode
{
    public class WorkflowSpecificationNodeHierarchyScopeRelRelationshipCollection : RelationshipCollection<WorkflowSpecificationNodeHierarchyScopeRelRelationship, Domain.isa95.CommonObjectModels.HierarchyScope>
    {
        public WorkflowSpecificationNodeHierarchyScopeRelRelationshipCollection(IEnumerable<WorkflowSpecificationNodeHierarchyScopeRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkflowSpecificationNodeHierarchyScopeRelRelationship>())
        {
        }
    }
}