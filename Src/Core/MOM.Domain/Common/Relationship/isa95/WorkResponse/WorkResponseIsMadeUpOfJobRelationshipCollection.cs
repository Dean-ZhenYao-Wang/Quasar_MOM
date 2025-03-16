namespace MOM.Domain.Common.Relationship.isa95.WorkResponse
{
    public class WorkResponseIsMadeUpOfJobRelationshipCollection : RelationshipCollection<WorkResponseIsMadeUpOfJobRelationship, Domain.isa95.CommonObjectModels.Part4.WorkPerformance.JobResponse>
    {
        public WorkResponseIsMadeUpOfJobRelationshipCollection(IEnumerable<WorkResponseIsMadeUpOfJobRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkResponseIsMadeUpOfJobRelationship>())
        {
        }
    }
}