namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetSpecificationProperty
{
    public class PhysicalAssetSpecificationPropertyMapsToClassPropertyRelationshipCollection : RelationshipCollection<PhysicalAssetSpecificationPropertyMapsToClassPropertyRelationship, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAssetClassProperty>
    {
        public PhysicalAssetSpecificationPropertyMapsToClassPropertyRelationshipCollection(IEnumerable<PhysicalAssetSpecificationPropertyMapsToClassPropertyRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PhysicalAssetSpecificationPropertyMapsToClassPropertyRelationship>())
        {
        }
    }
}