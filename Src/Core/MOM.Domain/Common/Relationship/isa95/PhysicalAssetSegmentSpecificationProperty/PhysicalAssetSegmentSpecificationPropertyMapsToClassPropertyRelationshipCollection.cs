namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetSegmentSpecificationProperty
{
    public class PhysicalAssetSegmentSpecificationPropertyMapsToClassPropertyRelationshipCollection : RelationshipCollection<PhysicalAssetSegmentSpecificationPropertyMapsToClassPropertyRelationship, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAssetClassProperty>
    {
        public PhysicalAssetSegmentSpecificationPropertyMapsToClassPropertyRelationshipCollection(IEnumerable<PhysicalAssetSegmentSpecificationPropertyMapsToClassPropertyRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PhysicalAssetSegmentSpecificationPropertyMapsToClassPropertyRelationship>())
        {
        }
    }
}