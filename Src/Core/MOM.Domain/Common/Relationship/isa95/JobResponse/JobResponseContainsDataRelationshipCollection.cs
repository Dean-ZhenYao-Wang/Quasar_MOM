namespace MOM.Domain.Common.Relationship.isa95.JobResponse
{
    public class JobResponseContainsDataRelationshipCollection : RelationshipCollection<JobResponseContainsDataRelationship, Domain.isa95.CommonObjectModels.Part4.WorkPerformance.JobResponseData>
    {
        public JobResponseContainsDataRelationshipCollection(IEnumerable<JobResponseContainsDataRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<JobResponseContainsDataRelationship>())
        {
        }
    }
}