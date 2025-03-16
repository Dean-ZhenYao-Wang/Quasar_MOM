namespace MOM.Domain.Common.Relationship.isa95.RequestedSegmentResponse
{
    public class RequestedSegmentResponseCorrespondsToAProcessSegmentRelationshipCollection : RelationshipCollection<RequestedSegmentResponseCorrespondsToAProcessSegmentRelationship, Domain.isa95.CommonObjectModels.Part2.ProcessSegment.ProcessSegment>
    {
        public RequestedSegmentResponseCorrespondsToAProcessSegmentRelationshipCollection(IEnumerable<RequestedSegmentResponseCorrespondsToAProcessSegmentRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<RequestedSegmentResponseCorrespondsToAProcessSegmentRelationship>())
        {
        }
    }
}