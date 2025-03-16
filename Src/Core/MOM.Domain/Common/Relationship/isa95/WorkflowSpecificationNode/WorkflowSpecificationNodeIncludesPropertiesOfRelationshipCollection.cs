namespace MOM.Domain.Common.Relationship.isa95.WorkflowSpecificationNode
{
    public class WorkflowSpecificationNodeIncludesPropertiesOfRelationshipCollection : RelationshipCollection<WorkflowSpecificationNodeIncludesPropertiesOfRelationship, Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationNode>
    {
        public WorkflowSpecificationNodeIncludesPropertiesOfRelationshipCollection(IEnumerable<WorkflowSpecificationNodeIncludesPropertiesOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkflowSpecificationNodeIncludesPropertiesOfRelationship>())
        {
        }
    }
}