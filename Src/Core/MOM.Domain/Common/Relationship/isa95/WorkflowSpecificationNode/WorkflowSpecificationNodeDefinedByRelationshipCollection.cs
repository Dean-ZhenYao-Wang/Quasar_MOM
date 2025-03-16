namespace MOM.Domain.Common.Relationship.isa95.WorkflowSpecificationNode
{
    public class WorkflowSpecificationNodeDefinedByRelationshipCollection : RelationshipCollection<WorkflowSpecificationNodeDefinedByRelationship, Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationNodeType>
    {
        public WorkflowSpecificationNodeDefinedByRelationshipCollection(IEnumerable<WorkflowSpecificationNodeDefinedByRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkflowSpecificationNodeDefinedByRelationship>())
        {
        }
    }
}