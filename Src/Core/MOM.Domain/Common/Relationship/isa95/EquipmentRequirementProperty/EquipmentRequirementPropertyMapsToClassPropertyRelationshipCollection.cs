namespace MOM.Domain.Common.Relationship.isa95.EquipmentRequirementProperty
{
    public class EquipmentRequirementPropertyMapsToClassPropertyRelationshipCollection : RelationshipCollection<EquipmentRequirementPropertyMapsToClassPropertyRelationship, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentClassProperty>
    {
        public EquipmentRequirementPropertyMapsToClassPropertyRelationshipCollection(IEnumerable<EquipmentRequirementPropertyMapsToClassPropertyRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<EquipmentRequirementPropertyMapsToClassPropertyRelationship>())
        {
        }
    }
}