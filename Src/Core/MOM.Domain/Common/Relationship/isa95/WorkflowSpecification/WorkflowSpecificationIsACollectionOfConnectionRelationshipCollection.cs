namespace MOM.Domain.Common.Relationship.isa95.WorkflowSpecification
{
    public class WorkflowSpecificationIsACollectionOfConnectionRelationshipCollection : RelationshipCollection<WorkflowSpecificationIsACollectionOfConnectionRelationship, Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationConnection>
    {
        public WorkflowSpecificationIsACollectionOfConnectionRelationshipCollection(IEnumerable<WorkflowSpecificationIsACollectionOfConnectionRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkflowSpecificationIsACollectionOfConnectionRelationship>())
        {
        }
    }
}