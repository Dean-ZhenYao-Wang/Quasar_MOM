namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetSpecificationProperty
{
    public class PhysicalAssetSpecificationPropertyMapsToPropertyRelationshipCollection : RelationshipCollection<PhysicalAssetSpecificationPropertyMapsToPropertyRelationship, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAssetProperty>
    {
        public PhysicalAssetSpecificationPropertyMapsToPropertyRelationshipCollection(IEnumerable<PhysicalAssetSpecificationPropertyMapsToPropertyRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PhysicalAssetSpecificationPropertyMapsToPropertyRelationship>())
        {
        }
    }
}