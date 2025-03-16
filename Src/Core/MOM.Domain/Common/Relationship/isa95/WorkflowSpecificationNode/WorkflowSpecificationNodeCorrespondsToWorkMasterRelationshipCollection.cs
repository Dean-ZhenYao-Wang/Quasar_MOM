namespace MOM.Domain.Common.Relationship.isa95.WorkflowSpecificationNode
{
    public class WorkflowSpecificationNodeCorrespondsToWorkMasterRelationshipCollection : RelationshipCollection<WorkflowSpecificationNodeCorrespondsToWorkMasterRelationship, Domain.isa95.CommonObjectModels.Part4.WorkDefinition.WorkMaster>
    {
        public WorkflowSpecificationNodeCorrespondsToWorkMasterRelationshipCollection(IEnumerable<WorkflowSpecificationNodeCorrespondsToWorkMasterRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkflowSpecificationNodeCorrespondsToWorkMasterRelationship>())
        {
        }
    }
}