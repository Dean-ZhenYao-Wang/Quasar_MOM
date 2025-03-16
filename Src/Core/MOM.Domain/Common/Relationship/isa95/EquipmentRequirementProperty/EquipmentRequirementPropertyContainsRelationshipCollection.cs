namespace MOM.Domain.Common.Relationship.isa95.EquipmentRequirementProperty
{
    public class EquipmentRequirementPropertyContainsRelationshipCollection : RelationshipCollection<EquipmentRequirementPropertyContainsRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.EquipmentRequirementProperty>
    {
        public EquipmentRequirementPropertyContainsRelationshipCollection(IEnumerable<EquipmentRequirementPropertyContainsRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<EquipmentRequirementPropertyContainsRelationship>())
        {
        }
    }
}