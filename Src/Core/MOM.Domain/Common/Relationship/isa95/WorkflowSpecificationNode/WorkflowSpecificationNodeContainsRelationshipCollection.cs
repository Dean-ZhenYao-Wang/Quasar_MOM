namespace MOM.Domain.Common.Relationship.isa95.WorkflowSpecificationNode
{
    public class WorkflowSpecificationNodeContainsRelationshipCollection : RelationshipCollection<WorkflowSpecificationNodeContainsRelationship, Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecification>
    {
        public WorkflowSpecificationNodeContainsRelationshipCollection(IEnumerable<WorkflowSpecificationNodeContainsRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkflowSpecificationNodeContainsRelationship>())
        {
        }
    }
}