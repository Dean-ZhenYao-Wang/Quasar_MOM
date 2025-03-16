namespace MOM.Domain.Common.Relationship.isa95.SegmentRequirement
{
    public class SegmentRequirementContainsEquipmentRelationshipCollection : RelationshipCollection<SegmentRequirementContainsEquipmentRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.EquipmentRequirement>
    {
        public SegmentRequirementContainsEquipmentRelationshipCollection(IEnumerable<SegmentRequirementContainsEquipmentRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<SegmentRequirementContainsEquipmentRelationship>())
        {
        }
    }
}