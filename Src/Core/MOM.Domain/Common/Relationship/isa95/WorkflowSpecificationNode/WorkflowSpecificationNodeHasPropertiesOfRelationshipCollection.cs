namespace MOM.Domain.Common.Relationship.isa95.WorkflowSpecificationNode
{
    public class WorkflowSpecificationNodeHasPropertiesOfRelationshipCollection : RelationshipCollection<WorkflowSpecificationNodeHasPropertiesOfRelationship, Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationNodeProperty>
    {
        public WorkflowSpecificationNodeHasPropertiesOfRelationshipCollection(IEnumerable<WorkflowSpecificationNodeHasPropertiesOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkflowSpecificationNodeHasPropertiesOfRelationship>())
        {
        }
    }
}