namespace MOM.Domain.Common.Relationship.isa95.SegmentParameter
{
    public class SegmentParameterCorrespondsToProcessRelationshipCollection : RelationshipCollection<SegmentParameterCorrespondsToProcessRelationship, Domain.isa95.CommonObjectModels.Part2.ProcessSegment.ProcessSegmentParameter>
    {
        public SegmentParameterCorrespondsToProcessRelationshipCollection(IEnumerable<SegmentParameterCorrespondsToProcessRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<SegmentParameterCorrespondsToProcessRelationship>())
        {
        }
    }
}