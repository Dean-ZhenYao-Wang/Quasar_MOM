namespace MOM.Domain.Common.Relationship.isa95.WorkflowSpecification
{
    public class WorkflowSpecificationIsACollectionOfNodeRelationshipCollection : RelationshipCollection<WorkflowSpecificationIsACollectionOfNodeRelationship, Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationNode>
    {
        public WorkflowSpecificationIsACollectionOfNodeRelationshipCollection(IEnumerable<WorkflowSpecificationIsACollectionOfNodeRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkflowSpecificationIsACollectionOfNodeRelationship>())
        {
        }
    }
}