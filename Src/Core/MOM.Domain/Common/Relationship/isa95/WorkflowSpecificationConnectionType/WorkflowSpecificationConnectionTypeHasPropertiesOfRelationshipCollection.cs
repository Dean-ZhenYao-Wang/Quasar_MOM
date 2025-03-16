namespace MOM.Domain.Common.Relationship.isa95.WorkflowSpecificationConnectionType
{
    public class WorkflowSpecificationConnectionTypeHasPropertiesOfRelationshipCollection : RelationshipCollection<WorkflowSpecificationConnectionTypeHasPropertiesOfRelationship, Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationConnectionTypeProperty>
    {
        public WorkflowSpecificationConnectionTypeHasPropertiesOfRelationshipCollection(IEnumerable<WorkflowSpecificationConnectionTypeHasPropertiesOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkflowSpecificationConnectionTypeHasPropertiesOfRelationship>())
        {
        }
    }
}