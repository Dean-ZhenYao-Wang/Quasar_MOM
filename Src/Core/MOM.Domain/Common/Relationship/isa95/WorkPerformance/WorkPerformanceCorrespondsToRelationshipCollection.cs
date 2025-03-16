namespace MOM.Domain.Common.Relationship.isa95.WorkPerformance
{
    public class WorkPerformanceCorrespondsToRelationshipCollection : RelationshipCollection<WorkPerformanceCorrespondsToRelationship, Domain.isa95.CommonObjectModels.Part4.WorkSchedule.WorkSchedule>
    {
        public WorkPerformanceCorrespondsToRelationshipCollection(IEnumerable<WorkPerformanceCorrespondsToRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkPerformanceCorrespondsToRelationship>())
        {
        }
    }
}