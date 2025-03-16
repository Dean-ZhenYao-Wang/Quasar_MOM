namespace MOM.Domain.Common.Relationship.isa95.SegmentResponse
{
    public class SegmentResponseContainsPhysicalAssetRelationshipCollection : RelationshipCollection<SegmentResponseContainsPhysicalAssetRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.PhysicalAssetActual>
    {
        public SegmentResponseContainsPhysicalAssetRelationshipCollection(IEnumerable<SegmentResponseContainsPhysicalAssetRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<SegmentResponseContainsPhysicalAssetRelationship>())
        {
        }
    }
}