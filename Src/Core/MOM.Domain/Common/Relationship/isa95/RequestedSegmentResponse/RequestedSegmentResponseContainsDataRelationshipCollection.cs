namespace MOM.Domain.Common.Relationship.isa95.RequestedSegmentResponse
{
    public class RequestedSegmentResponseContainsDataRelationshipCollection : RelationshipCollection<RequestedSegmentResponseContainsDataRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.SegmentData>
    {
        public RequestedSegmentResponseContainsDataRelationshipCollection(IEnumerable<RequestedSegmentResponseContainsDataRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<RequestedSegmentResponseContainsDataRelationship>())
        {
        }
    }
}