namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetActualProperty
{
    public class PhysicalAssetActualPropertyMapsToPropertyRelationshipCollection : RelationshipCollection<PhysicalAssetActualPropertyMapsToPropertyRelationship, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAssetProperty>
    {
        public PhysicalAssetActualPropertyMapsToPropertyRelationshipCollection(IEnumerable<PhysicalAssetActualPropertyMapsToPropertyRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PhysicalAssetActualPropertyMapsToPropertyRelationship>())
        {
        }
    }
}