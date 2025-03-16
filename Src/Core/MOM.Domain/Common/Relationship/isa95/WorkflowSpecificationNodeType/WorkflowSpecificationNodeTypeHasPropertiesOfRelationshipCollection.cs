namespace MOM.Domain.Common.Relationship.isa95.WorkflowSpecificationNodeType
{
    public class WorkflowSpecificationNodeTypeHasPropertiesOfRelationshipCollection : RelationshipCollection<WorkflowSpecificationNodeTypeHasPropertiesOfRelationship, Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationNodeTypeProperty>
    {
        public WorkflowSpecificationNodeTypeHasPropertiesOfRelationshipCollection(IEnumerable<WorkflowSpecificationNodeTypeHasPropertiesOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkflowSpecificationNodeTypeHasPropertiesOfRelationship>())
        {
        }
    }
}