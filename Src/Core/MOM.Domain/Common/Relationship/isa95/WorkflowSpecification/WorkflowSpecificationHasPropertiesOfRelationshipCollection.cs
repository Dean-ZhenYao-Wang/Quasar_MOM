namespace MOM.Domain.Common.Relationship.isa95.WorkflowSpecification
{
    public class WorkflowSpecificationHasPropertiesOfRelationshipCollection : RelationshipCollection<WorkflowSpecificationHasPropertiesOfRelationship, Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationProperty>
    {
        public WorkflowSpecificationHasPropertiesOfRelationshipCollection(IEnumerable<WorkflowSpecificationHasPropertiesOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkflowSpecificationHasPropertiesOfRelationship>())
        {
        }
    }
}