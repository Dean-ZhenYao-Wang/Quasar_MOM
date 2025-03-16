namespace MOM.Domain.Common.Relationship.isa95.SegmentResponse
{
    public class SegmentResponseContainsEquipmentRelationshipCollection : RelationshipCollection<SegmentResponseContainsEquipmentRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.EquipmentActual>
    {
        public SegmentResponseContainsEquipmentRelationshipCollection(IEnumerable<SegmentResponseContainsEquipmentRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<SegmentResponseContainsEquipmentRelationship>())
        {
        }
    }
}