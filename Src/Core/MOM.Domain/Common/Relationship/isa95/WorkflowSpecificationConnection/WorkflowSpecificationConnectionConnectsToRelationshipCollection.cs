namespace MOM.Domain.Common.Relationship.isa95.WorkflowSpecificationConnection
{
    public class WorkflowSpecificationConnectionConnectsToRelationshipCollection : RelationshipCollection<WorkflowSpecificationConnectionConnectsToRelationship, Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationNode>
    {
        public WorkflowSpecificationConnectionConnectsToRelationshipCollection(IEnumerable<WorkflowSpecificationConnectionConnectsToRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkflowSpecificationConnectionConnectsToRelationship>())
        {
        }
    }
}