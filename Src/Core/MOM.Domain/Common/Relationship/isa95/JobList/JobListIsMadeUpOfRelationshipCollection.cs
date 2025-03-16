namespace MOM.Domain.Common.Relationship.isa95.JobList
{
    public class JobListIsMadeUpOfRelationshipCollection : RelationshipCollection<JobListIsMadeUpOfRelationship, Domain.isa95.CommonObjectModels.Part4.WorkSchedule.JobOrder>
    {
        public JobListIsMadeUpOfRelationshipCollection(IEnumerable<JobListIsMadeUpOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<JobListIsMadeUpOfRelationship>())
        {
        }
    }
}