namespace MOM.Domain.Common.Relationship.isa95.WorkMaster
{
    public class WorkMasterHasARelationshipCollection : RelationshipCollection<WorkMasterHasARelationship, Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecification>
    {
        public WorkMasterHasARelationshipCollection(IEnumerable<WorkMasterHasARelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkMasterHasARelationship>())
        {
        }
    }
}