namespace MOM.Domain.Common.Relationship.isa95.WorkflowSpecificationConnection
{
    public class WorkflowSpecificationConnectionConnectsFromRelationshipCollection : RelationshipCollection<WorkflowSpecificationConnectionConnectsFromRelationship, Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationNode>
    {
        public WorkflowSpecificationConnectionConnectsFromRelationshipCollection(IEnumerable<WorkflowSpecificationConnectionConnectsFromRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkflowSpecificationConnectionConnectsFromRelationship>())
        {
        }
    }
}