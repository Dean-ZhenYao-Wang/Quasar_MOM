namespace MOM.Domain.Common.Relationship.isa95.EquipmentCapabilityProperty
{
    public class EquipmentCapabilityPropertyMapsToPropertyRelationshipCollection : RelationshipCollection<EquipmentCapabilityPropertyMapsToPropertyRelationship, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentProperty>
    {
        public EquipmentCapabilityPropertyMapsToPropertyRelationshipCollection(IEnumerable<EquipmentCapabilityPropertyMapsToPropertyRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<EquipmentCapabilityPropertyMapsToPropertyRelationship>())
        {
        }
    }
}