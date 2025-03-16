namespace MOM.Domain.Common.Relationship.isa95.WorkflowSpecificationConnectionProperty
{
    public class WorkflowSpecificationConnectionPropertyContainsRelationshipCollection : RelationshipCollection<WorkflowSpecificationConnectionPropertyContainsRelationship, Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationConnectionProperty>
    {
        public WorkflowSpecificationConnectionPropertyContainsRelationshipCollection(IEnumerable<WorkflowSpecificationConnectionPropertyContainsRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkflowSpecificationConnectionPropertyContainsRelationship>())
        {
        }
    }
}