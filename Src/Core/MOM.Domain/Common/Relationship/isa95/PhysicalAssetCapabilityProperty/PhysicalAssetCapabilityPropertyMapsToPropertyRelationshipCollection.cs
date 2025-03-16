namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetCapabilityProperty
{
    public class PhysicalAssetCapabilityPropertyMapsToPropertyRelationshipCollection : RelationshipCollection<PhysicalAssetCapabilityPropertyMapsToPropertyRelationship, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAssetProperty>
    {
        public PhysicalAssetCapabilityPropertyMapsToPropertyRelationshipCollection(IEnumerable<PhysicalAssetCapabilityPropertyMapsToPropertyRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PhysicalAssetCapabilityPropertyMapsToPropertyRelationship>())
        {
        }
    }
}