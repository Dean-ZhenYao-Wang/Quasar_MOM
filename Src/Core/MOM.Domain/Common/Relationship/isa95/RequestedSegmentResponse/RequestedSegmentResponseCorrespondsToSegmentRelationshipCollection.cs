namespace MOM.Domain.Common.Relationship.isa95.RequestedSegmentResponse
{
    public class RequestedSegmentResponseCorrespondsToSegmentRelationshipCollection : RelationshipCollection<RequestedSegmentResponseCorrespondsToSegmentRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsSegment>
    {
        public RequestedSegmentResponseCorrespondsToSegmentRelationshipCollection(IEnumerable<RequestedSegmentResponseCorrespondsToSegmentRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<RequestedSegmentResponseCorrespondsToSegmentRelationship>())
        {
        }
    }
}