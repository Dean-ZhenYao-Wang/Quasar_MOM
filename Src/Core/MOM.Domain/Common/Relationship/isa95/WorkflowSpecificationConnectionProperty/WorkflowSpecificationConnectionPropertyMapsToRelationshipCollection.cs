namespace MOM.Domain.Common.Relationship.isa95.WorkflowSpecificationConnectionProperty
{
    public class WorkflowSpecificationConnectionPropertyMapsToRelationshipCollection : RelationshipCollection<WorkflowSpecificationConnectionPropertyMapsToRelationship, Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationConnectionTypeProperty>
    {
        public WorkflowSpecificationConnectionPropertyMapsToRelationshipCollection(IEnumerable<WorkflowSpecificationConnectionPropertyMapsToRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkflowSpecificationConnectionPropertyMapsToRelationship>())
        {
        }
    }
}