namespace MOM.Domain.Common.Relationship.isa95.JobResponseData
{
    public class JobResponseDataContainsRelationshipCollection : RelationshipCollection<JobResponseDataContainsRelationship, Domain.isa95.CommonObjectModels.Part4.WorkPerformance.JobResponseData>
    {
        public JobResponseDataContainsRelationshipCollection(IEnumerable<JobResponseDataContainsRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<JobResponseDataContainsRelationship>())
        {
        }
    }
}