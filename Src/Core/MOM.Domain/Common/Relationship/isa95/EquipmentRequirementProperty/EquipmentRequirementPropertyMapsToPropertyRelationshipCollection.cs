namespace MOM.Domain.Common.Relationship.isa95.EquipmentRequirementProperty
{
    public class EquipmentRequirementPropertyMapsToPropertyRelationshipCollection : RelationshipCollection<EquipmentRequirementPropertyMapsToPropertyRelationship, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentProperty>
    {
        public EquipmentRequirementPropertyMapsToPropertyRelationshipCollection(IEnumerable<EquipmentRequirementPropertyMapsToPropertyRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<EquipmentRequirementPropertyMapsToPropertyRelationship>())
        {
        }
    }
}