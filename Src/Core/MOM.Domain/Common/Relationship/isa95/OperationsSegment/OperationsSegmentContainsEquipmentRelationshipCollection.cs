namespace MOM.Domain.Common.Relationship.isa95.OperationsSegment
{
    public class OperationsSegmentContainsEquipmentRelationshipCollection : RelationshipCollection<OperationsSegmentContainsEquipmentRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.EquipmentSpecification>
    {
        public OperationsSegmentContainsEquipmentRelationshipCollection(IEnumerable<OperationsSegmentContainsEquipmentRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsSegmentContainsEquipmentRelationship>())
        {
        }
    }
}