namespace MOM.Domain.Common.Relationship.isa95.EquipmentSpecificationProperty
{
    public class EquipmentSpecificationPropertyMapsToPropertyRelationshipCollection : RelationshipCollection<EquipmentSpecificationPropertyMapsToPropertyRelationship, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentProperty>
    {
        public EquipmentSpecificationPropertyMapsToPropertyRelationshipCollection(IEnumerable<EquipmentSpecificationPropertyMapsToPropertyRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<EquipmentSpecificationPropertyMapsToPropertyRelationship>())
        {
        }
    }
}