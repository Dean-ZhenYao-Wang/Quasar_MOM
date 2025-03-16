namespace MOM.Domain.Common.Relationship.isa95.WorkflowSpecification
{
    public class WorkflowSpecificationIncludesPropertiesOfRelationshipCollection : RelationshipCollection<WorkflowSpecificationIncludesPropertiesOfRelationship, Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecification>
    {
        public WorkflowSpecificationIncludesPropertiesOfRelationshipCollection(IEnumerable<WorkflowSpecificationIncludesPropertiesOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkflowSpecificationIncludesPropertiesOfRelationship>())
        {
        }
    }
}