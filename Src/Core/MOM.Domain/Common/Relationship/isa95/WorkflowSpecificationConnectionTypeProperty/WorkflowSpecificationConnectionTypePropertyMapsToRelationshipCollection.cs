namespace MOM.Domain.Common.Relationship.isa95.WorkflowSpecificationConnectionTypeProperty
{
    public class WorkflowSpecificationConnectionTypePropertyMapsToRelationshipCollection : RelationshipCollection<WorkflowSpecificationConnectionTypePropertyMapsToRelationship, Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationConnectionProperty>
    {
        public WorkflowSpecificationConnectionTypePropertyMapsToRelationshipCollection(IEnumerable<WorkflowSpecificationConnectionTypePropertyMapsToRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkflowSpecificationConnectionTypePropertyMapsToRelationship>())
        {
        }
    }
}