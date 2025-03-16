namespace MOM.Domain.Common.Relationship.isa95.EquipmentRequirement
{
    public class EquipmentRequirementIsMadeUpOfRelationshipCollection : RelationshipCollection<EquipmentRequirementIsMadeUpOfRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.EquipmentRequirement>
    {
        public EquipmentRequirementIsMadeUpOfRelationshipCollection(IEnumerable<EquipmentRequirementIsMadeUpOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<EquipmentRequirementIsMadeUpOfRelationship>())
        {
        }
    }
}