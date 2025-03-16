namespace MOM.Domain.Common.Relationship.isa95.WorkPerformance
{
    public class WorkPerformanceIsMadeUpOfPerformanceRelationshipCollection : RelationshipCollection<WorkPerformanceIsMadeUpOfPerformanceRelationship, Domain.isa95.CommonObjectModels.Part4.WorkPerformance.WorkPerformance>
    {
        public WorkPerformanceIsMadeUpOfPerformanceRelationshipCollection(IEnumerable<WorkPerformanceIsMadeUpOfPerformanceRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkPerformanceIsMadeUpOfPerformanceRelationship>())
        {
        }
    }
}