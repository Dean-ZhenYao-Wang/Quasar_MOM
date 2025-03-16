namespace MOM.Domain.Common.Relationship.isa95.SegmentResponse
{
    public class SegmentResponseContainsMaterialRelationshipCollection : RelationshipCollection<SegmentResponseContainsMaterialRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.MaterialActual>
    {
        public SegmentResponseContainsMaterialRelationshipCollection(IEnumerable<SegmentResponseContainsMaterialRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<SegmentResponseContainsMaterialRelationship>())
        {
        }
    }
}