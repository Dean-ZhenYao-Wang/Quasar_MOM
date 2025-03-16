namespace MOM.Domain.Common.Relationship.isa95.SegmentResponse
{
    public class SegmentResponseContainsDataRelationshipCollection : RelationshipCollection<SegmentResponseContainsDataRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.SegmentData>
    {
        public SegmentResponseContainsDataRelationshipCollection(IEnumerable<SegmentResponseContainsDataRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<SegmentResponseContainsDataRelationship>())
        {
        }
    }
}