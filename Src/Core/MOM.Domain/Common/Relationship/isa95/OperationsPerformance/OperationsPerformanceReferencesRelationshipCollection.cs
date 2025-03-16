namespace MOM.Domain.Common.Relationship.isa95.OperationsPerformance
{
    public class OperationsPerformanceReferencesRelationshipCollection : RelationshipCollection<OperationsPerformanceReferencesRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.OperationsSchedule>
    {
        public OperationsPerformanceReferencesRelationshipCollection(IEnumerable<OperationsPerformanceReferencesRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsPerformanceReferencesRelationship>())
        {
        }
    }
}