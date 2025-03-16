namespace MOM.Domain.Common.Relationship.isa95.SegmentResponse
{
    public class SegmentResponseCorrespondsToSegmentRelationshipCollection : RelationshipCollection<SegmentResponseCorrespondsToSegmentRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsSegment>
    {
        public SegmentResponseCorrespondsToSegmentRelationshipCollection(IEnumerable<SegmentResponseCorrespondsToSegmentRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<SegmentResponseCorrespondsToSegmentRelationship>())
        {
        }
    }
}