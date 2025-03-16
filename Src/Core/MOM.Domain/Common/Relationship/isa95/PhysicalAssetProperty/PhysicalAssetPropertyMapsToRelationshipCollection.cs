namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetProperty
{
    public class PhysicalAssetPropertyMapsToRelationshipCollection : RelationshipCollection<PhysicalAssetPropertyMapsToRelationship, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAssetClassProperty>
    {
        public PhysicalAssetPropertyMapsToRelationshipCollection(IEnumerable<PhysicalAssetPropertyMapsToRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PhysicalAssetPropertyMapsToRelationship>())
        {
        }
    }
}