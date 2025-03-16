namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetSegmentSpecificationProperty
{
    public class PhysicalAssetSegmentSpecificationPropertyMapsToPropertyRelationshipCollection : RelationshipCollection<PhysicalAssetSegmentSpecificationPropertyMapsToPropertyRelationship, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAssetProperty>
    {
        public PhysicalAssetSegmentSpecificationPropertyMapsToPropertyRelationshipCollection(IEnumerable<PhysicalAssetSegmentSpecificationPropertyMapsToPropertyRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PhysicalAssetSegmentSpecificationPropertyMapsToPropertyRelationship>())
        {
        }
    }
}