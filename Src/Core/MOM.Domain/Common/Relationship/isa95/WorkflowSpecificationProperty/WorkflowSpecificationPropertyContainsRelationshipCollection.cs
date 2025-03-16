namespace MOM.Domain.Common.Relationship.isa95.WorkflowSpecificationProperty
{
    public class WorkflowSpecificationPropertyContainsRelationshipCollection : RelationshipCollection<WorkflowSpecificationPropertyContainsRelationship, Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationProperty>
    {
        public WorkflowSpecificationPropertyContainsRelationshipCollection(IEnumerable<WorkflowSpecificationPropertyContainsRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkflowSpecificationPropertyContainsRelationship>())
        {
        }
    }
}