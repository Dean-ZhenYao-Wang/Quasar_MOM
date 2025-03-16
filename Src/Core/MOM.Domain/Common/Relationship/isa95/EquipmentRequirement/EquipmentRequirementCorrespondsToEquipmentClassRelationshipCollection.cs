namespace MOM.Domain.Common.Relationship.isa95.EquipmentRequirement
{
    public class EquipmentRequirementCorrespondsToEquipmentClassRelationshipCollection : RelationshipCollection<EquipmentRequirementCorrespondsToEquipmentClassRelationship, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentClass>
    {
        public EquipmentRequirementCorrespondsToEquipmentClassRelationshipCollection(IEnumerable<EquipmentRequirementCorrespondsToEquipmentClassRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<EquipmentRequirementCorrespondsToEquipmentClassRelationship>())
        {
        }
    }
}