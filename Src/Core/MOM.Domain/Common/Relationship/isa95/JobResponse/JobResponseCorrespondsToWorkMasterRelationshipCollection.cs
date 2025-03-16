namespace MOM.Domain.Common.Relationship.isa95.JobResponse
{
    public class JobResponseCorrespondsToWorkMasterRelationshipCollection : RelationshipCollection<JobResponseCorrespondsToWorkMasterRelationship, MOM.Domain.isa95.CommonObjectModels.Part4.WorkDefinition.WorkMaster>
    {
        public JobResponseCorrespondsToWorkMasterRelationshipCollection(IEnumerable<JobResponseCorrespondsToWorkMasterRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<JobResponseCorrespondsToWorkMasterRelationship>())
        {
        }
    }
}