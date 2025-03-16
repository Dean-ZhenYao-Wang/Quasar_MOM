namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetClass
{
    public class PhysicalAssetClassIsMadeUpOfRelationshipCollection : RelationshipCollection<PhysicalAssetClassIsMadeUpOfRelationship, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAssetClass>
    {
        public PhysicalAssetClassIsMadeUpOfRelationshipCollection(IEnumerable<PhysicalAssetClassIsMadeUpOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PhysicalAssetClassIsMadeUpOfRelationship>())
        {
        }
    }
}