namespace MOM.Domain.Common.Relationship.isa95.JobOrder
{
    public class JobOrderCorrespondsToWorkMasterRelationshipCollection : RelationshipCollection<JobOrderCorrespondsToWorkMasterRelationship, Domain.isa95.CommonObjectModels.Part4.WorkDefinition.WorkMaster>
    {
        public JobOrderCorrespondsToWorkMasterRelationshipCollection(IEnumerable<JobOrderCorrespondsToWorkMasterRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<JobOrderCorrespondsToWorkMasterRelationship>())
        {
        }
    }
}