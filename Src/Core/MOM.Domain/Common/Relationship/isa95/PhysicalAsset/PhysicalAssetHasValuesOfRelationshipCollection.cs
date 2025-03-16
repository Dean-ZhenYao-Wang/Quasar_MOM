namespace MOM.Domain.Common.Relationship.isa95.PhysicalAsset
{
    public class PhysicalAssetHasValuesOfRelationshipCollection : RelationshipCollection<PhysicalAssetHasValuesOfRelationship, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAssetProperty>
    {
        public PhysicalAssetHasValuesOfRelationshipCollection(IEnumerable<PhysicalAssetHasValuesOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PhysicalAssetHasValuesOfRelationship>())
        {
        }
    }
}