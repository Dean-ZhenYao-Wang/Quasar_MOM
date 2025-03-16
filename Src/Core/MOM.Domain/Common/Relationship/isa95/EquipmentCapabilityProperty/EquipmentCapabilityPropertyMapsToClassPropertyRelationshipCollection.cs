namespace MOM.Domain.Common.Relationship.isa95.EquipmentCapabilityProperty
{
    public class EquipmentCapabilityPropertyMapsToClassPropertyRelationshipCollection : RelationshipCollection<EquipmentCapabilityPropertyMapsToClassPropertyRelationship, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentClassProperty>
    {
        public EquipmentCapabilityPropertyMapsToClassPropertyRelationshipCollection(IEnumerable<EquipmentCapabilityPropertyMapsToClassPropertyRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<EquipmentCapabilityPropertyMapsToClassPropertyRelationship>())
        {
        }
    }
}