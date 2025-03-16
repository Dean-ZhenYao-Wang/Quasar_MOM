namespace MOM.Domain.Common.Relationship.isa95.SegmentResponse
{
    public class SegmentResponseIsMadeUpOfRelationshipCollection : RelationshipCollection<SegmentResponseIsMadeUpOfRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.SegmentResponse>
    {
        public SegmentResponseIsMadeUpOfRelationshipCollection(IEnumerable<SegmentResponseIsMadeUpOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<SegmentResponseIsMadeUpOfRelationship>())
        {
        }
    }
}