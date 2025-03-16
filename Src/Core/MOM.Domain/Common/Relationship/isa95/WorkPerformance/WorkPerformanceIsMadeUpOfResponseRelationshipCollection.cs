namespace MOM.Domain.Common.Relationship.isa95.WorkPerformance
{
    public class WorkPerformanceIsMadeUpOfResponseRelationshipCollection : RelationshipCollection<WorkPerformanceIsMadeUpOfResponseRelationship, Domain.isa95.CommonObjectModels.Part4.WorkPerformance.WorkResponse>
    {
        public WorkPerformanceIsMadeUpOfResponseRelationshipCollection(IEnumerable<WorkPerformanceIsMadeUpOfResponseRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkPerformanceIsMadeUpOfResponseRelationship>())
        {
        }
    }
}