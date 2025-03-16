namespace MOM.Domain.Common.Relationship.isa95.EquipmentRequirement
{
    public class EquipmentRequirementHasValuesOfRelationshipCollection : RelationshipCollection<EquipmentRequirementHasValuesOfRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.EquipmentRequirementProperty>
    {
        public EquipmentRequirementHasValuesOfRelationshipCollection(IEnumerable<EquipmentRequirementHasValuesOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<EquipmentRequirementHasValuesOfRelationship>())
        {
        }
    }
}