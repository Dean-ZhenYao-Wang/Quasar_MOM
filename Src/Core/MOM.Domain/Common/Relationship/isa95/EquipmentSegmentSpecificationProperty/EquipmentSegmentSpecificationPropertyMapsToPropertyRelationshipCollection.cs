namespace MOM.Domain.Common.Relationship.isa95.EquipmentSegmentSpecificationProperty
{
    public class EquipmentSegmentSpecificationPropertyMapsToPropertyRelationshipCollection : RelationshipCollection<EquipmentSegmentSpecificationPropertyMapsToPropertyRelationship, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentProperty>
    {
        public EquipmentSegmentSpecificationPropertyMapsToPropertyRelationshipCollection(IEnumerable<EquipmentSegmentSpecificationPropertyMapsToPropertyRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<EquipmentSegmentSpecificationPropertyMapsToPropertyRelationship>())
        {
        }
    }
}