namespace MOM.Domain.Common.Relationship.isa95.WorkflowSpecificationNodeProperty
{
    public class WorkflowSpecificationNodePropertyMapsToRelationshipCollection : RelationshipCollection<WorkflowSpecificationNodePropertyMapsToRelationship, Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationNodeTypeProperty>
    {
        public WorkflowSpecificationNodePropertyMapsToRelationshipCollection(IEnumerable<WorkflowSpecificationNodePropertyMapsToRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkflowSpecificationNodePropertyMapsToRelationship>())
        {
        }
    }
}