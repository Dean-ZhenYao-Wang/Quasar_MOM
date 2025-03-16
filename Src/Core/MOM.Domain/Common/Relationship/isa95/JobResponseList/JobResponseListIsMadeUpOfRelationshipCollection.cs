namespace MOM.Domain.Common.Relationship.isa95.JobResponseList
{
    public class JobResponseListIsMadeUpOfRelationshipCollection : RelationshipCollection<JobResponseListIsMadeUpOfRelationship, Domain.isa95.CommonObjectModels.Part4.WorkPerformance.JobResponse>
    {
        public JobResponseListIsMadeUpOfRelationshipCollection(IEnumerable<JobResponseListIsMadeUpOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<JobResponseListIsMadeUpOfRelationship>())
        {
        }
    }
}