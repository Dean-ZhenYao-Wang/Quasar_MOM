namespace MOM.Domain.Common.Relationship.isa95.WorkflowSpecificationConnection
{
    public class WorkflowSpecificationConnectionDefinedByRelationshipCollection : RelationshipCollection<WorkflowSpecificationConnectionDefinedByRelationship, Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationConnectionType>
    {
        public WorkflowSpecificationConnectionDefinedByRelationshipCollection(IEnumerable<WorkflowSpecificationConnectionDefinedByRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkflowSpecificationConnectionDefinedByRelationship>())
        {
        }
    }
}