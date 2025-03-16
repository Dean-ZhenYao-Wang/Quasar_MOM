namespace MOM.Domain.Common.Relationship.isa95.OperationsPerformance
{
    public class OperationsPerformanceIsMadeUpOfRelationshipCollection : RelationshipCollection<OperationsPerformanceIsMadeUpOfRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.OperationsResponse>
    {
        public OperationsPerformanceIsMadeUpOfRelationshipCollection(IEnumerable<OperationsPerformanceIsMadeUpOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsPerformanceIsMadeUpOfRelationship>())
        {
        }
    }
}