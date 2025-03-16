namespace MOM.Domain.Common.Relationship.isa95.JobResponse
{
    public class JobResponseCorrespondsToJobOrderRelationshipCollection : RelationshipCollection<JobResponseCorrespondsToJobOrderRelationship, Domain.isa95.CommonObjectModels.Part4.WorkSchedule.JobOrder>
    {
        public JobResponseCorrespondsToJobOrderRelationshipCollection(IEnumerable<JobResponseCorrespondsToJobOrderRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<JobResponseCorrespondsToJobOrderRelationship>())
        {
        }
    }
}