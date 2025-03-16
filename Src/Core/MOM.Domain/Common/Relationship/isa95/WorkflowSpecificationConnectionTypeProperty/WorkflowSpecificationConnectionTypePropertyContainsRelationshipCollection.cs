namespace MOM.Domain.Common.Relationship.isa95.WorkflowSpecificationConnectionTypeProperty
{
    public class WorkflowSpecificationConnectionTypePropertyContainsRelationshipCollection : RelationshipCollection<WorkflowSpecificationConnectionTypePropertyContainsRelationship, Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationNodeTypeProperty>
    {
        public WorkflowSpecificationConnectionTypePropertyContainsRelationshipCollection(IEnumerable<WorkflowSpecificationConnectionTypePropertyContainsRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkflowSpecificationConnectionTypePropertyContainsRelationship>())
        {
        }
    }
}