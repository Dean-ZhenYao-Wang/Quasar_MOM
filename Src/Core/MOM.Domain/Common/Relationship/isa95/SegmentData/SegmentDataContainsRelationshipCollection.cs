namespace MOM.Domain.Common.Relationship.isa95.SegmentData
{
    public class SegmentDataContainsRelationshipCollection : RelationshipCollection<SegmentDataContainsRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.SegmentData>
    {
        public SegmentDataContainsRelationshipCollection(IEnumerable<SegmentDataContainsRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<SegmentDataContainsRelationship>())
        {
        }
    }
}