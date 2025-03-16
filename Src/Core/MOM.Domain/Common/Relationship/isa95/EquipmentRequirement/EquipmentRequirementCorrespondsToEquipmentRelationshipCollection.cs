namespace MOM.Domain.Common.Relationship.isa95.EquipmentRequirement
{
    public class EquipmentRequirementCorrespondsToEquipmentRelationshipCollection : RelationshipCollection<EquipmentRequirementCorrespondsToEquipmentRelationship, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.Equipment>
    {
        public EquipmentRequirementCorrespondsToEquipmentRelationshipCollection(IEnumerable<EquipmentRequirementCorrespondsToEquipmentRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<EquipmentRequirementCorrespondsToEquipmentRelationship>())
        {
        }
    }
}