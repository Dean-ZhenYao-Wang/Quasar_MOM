namespace MOM.Domain.Common.Relationship.isa95.WorkflowSpecificationNodeProperty
{
    public class WorkflowSpecificationNodePropertyContainsRelationshipCollection : RelationshipCollection<WorkflowSpecificationNodePropertyContainsRelationship, Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationNodeProperty>
    {
        public WorkflowSpecificationNodePropertyContainsRelationshipCollection(IEnumerable<WorkflowSpecificationNodePropertyContainsRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkflowSpecificationNodePropertyContainsRelationship>())
        {
        }
    }
}