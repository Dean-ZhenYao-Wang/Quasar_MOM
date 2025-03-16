namespace MOM.Domain.Common.Relationship.isa95.PhysicalAsset
{
    public class PhysicalAssetIsMadeUpOfRelationshipCollection : RelationshipCollection<PhysicalAssetIsMadeUpOfRelationship, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAsset>
    {
        public PhysicalAssetIsMadeUpOfRelationshipCollection(IEnumerable<PhysicalAssetIsMadeUpOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PhysicalAssetIsMadeUpOfRelationship>())
        {
        }
    }
}