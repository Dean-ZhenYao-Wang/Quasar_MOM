namespace MOM.Domain.Common.Relationship.isa95.WorkflowSpecificationConnection
{
    public class WorkflowSpecificationConnectionHasPropertiesOfRelationshipCollection : RelationshipCollection<WorkflowSpecificationConnectionHasPropertiesOfRelationship, Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationConnectionProperty>
    {
        public WorkflowSpecificationConnectionHasPropertiesOfRelationshipCollection(IEnumerable<WorkflowSpecificationConnectionHasPropertiesOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkflowSpecificationConnectionHasPropertiesOfRelationship>())
        {
        }
    }
}