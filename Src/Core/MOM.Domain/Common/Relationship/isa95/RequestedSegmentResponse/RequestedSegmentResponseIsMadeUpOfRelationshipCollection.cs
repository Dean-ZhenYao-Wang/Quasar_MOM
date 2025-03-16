namespace MOM.Domain.Common.Relationship.isa95.RequestedSegmentResponse
{
    public class RequestedSegmentResponseIsMadeUpOfRelationshipCollection : RelationshipCollection<RequestedSegmentResponseIsMadeUpOfRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.SegmentResponse>
    {
        public RequestedSegmentResponseIsMadeUpOfRelationshipCollection(IEnumerable<RequestedSegmentResponseIsMadeUpOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<RequestedSegmentResponseIsMadeUpOfRelationship>())
        {
        }
    }
}