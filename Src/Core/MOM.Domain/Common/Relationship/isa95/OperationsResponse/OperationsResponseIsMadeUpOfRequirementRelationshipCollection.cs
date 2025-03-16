namespace MOM.Domain.Common.Relationship.isa95.OperationsResponse
{
    public class OperationsResponseIsMadeUpOfRequirementRelationshipCollection : RelationshipCollection<OperationsResponseIsMadeUpOfRequirementRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.SegmentResponse>
    {
        public OperationsResponseIsMadeUpOfRequirementRelationshipCollection(IEnumerable<OperationsResponseIsMadeUpOfRequirementRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsResponseIsMadeUpOfRequirementRelationship>())
        {
        }
    }
}