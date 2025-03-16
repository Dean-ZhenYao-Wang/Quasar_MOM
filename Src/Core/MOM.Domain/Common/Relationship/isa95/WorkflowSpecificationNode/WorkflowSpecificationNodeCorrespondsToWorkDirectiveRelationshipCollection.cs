namespace MOM.Domain.Common.Relationship.isa95.WorkflowSpecificationNode
{
    public class WorkflowSpecificationNodeCorrespondsToWorkDirectiveRelationshipCollection : RelationshipCollection<WorkflowSpecificationNodeCorrespondsToWorkDirectiveRelationship, MOM.Domain.isa95.CommonObjectModels.Part4.WorkDefinition.WorkDirective>
    {
        public WorkflowSpecificationNodeCorrespondsToWorkDirectiveRelationshipCollection(IEnumerable<WorkflowSpecificationNodeCorrespondsToWorkDirectiveRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkflowSpecificationNodeCorrespondsToWorkDirectiveRelationship>())
        {
        }
    }
}