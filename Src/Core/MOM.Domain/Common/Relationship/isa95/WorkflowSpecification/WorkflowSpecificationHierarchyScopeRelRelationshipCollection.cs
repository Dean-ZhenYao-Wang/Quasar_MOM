namespace MOM.Domain.Common.Relationship.isa95.WorkflowSpecification
{
    public class WorkflowSpecificationHierarchyScopeRelRelationshipCollection : RelationshipCollection<WorkflowSpecificationHierarchyScopeRelRelationship, Domain.isa95.CommonObjectModels.HierarchyScope>
    {
        public WorkflowSpecificationHierarchyScopeRelRelationshipCollection(IEnumerable<WorkflowSpecificationHierarchyScopeRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkflowSpecificationHierarchyScopeRelRelationship>())
        {
        }
    }
}