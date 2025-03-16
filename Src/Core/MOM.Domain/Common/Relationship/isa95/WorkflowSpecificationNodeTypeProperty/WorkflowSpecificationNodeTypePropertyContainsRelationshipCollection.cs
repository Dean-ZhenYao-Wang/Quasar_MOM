namespace MOM.Domain.Common.Relationship.isa95.WorkflowSpecificationNodeTypeProperty
{
    public class WorkflowSpecificationNodeTypePropertyContainsRelationshipCollection : RelationshipCollection<WorkflowSpecificationNodeTypePropertyContainsRelationship, Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationNodeTypeProperty>
    {
        public WorkflowSpecificationNodeTypePropertyContainsRelationshipCollection(IEnumerable<WorkflowSpecificationNodeTypePropertyContainsRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkflowSpecificationNodeTypePropertyContainsRelationship>())
        {
        }
    }
}