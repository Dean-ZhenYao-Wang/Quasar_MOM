namespace MOM.Domain.Common.Relationship.isa95.SegmentResponse
{
    public class SegmentResponseCorrespondsToAProcessSegmentRelationshipCollection : RelationshipCollection<SegmentResponseCorrespondsToAProcessSegmentRelationship, Domain.isa95.CommonObjectModels.Part2.ProcessSegment.ProcessSegment>
    {
        public SegmentResponseCorrespondsToAProcessSegmentRelationshipCollection(IEnumerable<SegmentResponseCorrespondsToAProcessSegmentRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<SegmentResponseCorrespondsToAProcessSegmentRelationship>())
        {
        }
    }
}