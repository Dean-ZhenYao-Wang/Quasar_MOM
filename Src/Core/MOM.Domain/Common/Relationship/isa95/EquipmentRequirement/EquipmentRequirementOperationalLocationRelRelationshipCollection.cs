namespace MOM.Domain.Common.Relationship.isa95.EquipmentRequirement
{
    public class EquipmentRequirementOperationalLocationRelRelationshipCollection : RelationshipCollection<EquipmentRequirementOperationalLocationRelRelationship, Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation>
    {
        public EquipmentRequirementOperationalLocationRelRelationshipCollection(IEnumerable<EquipmentRequirementOperationalLocationRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<EquipmentRequirementOperationalLocationRelRelationship>())
        {
        }
    }
}