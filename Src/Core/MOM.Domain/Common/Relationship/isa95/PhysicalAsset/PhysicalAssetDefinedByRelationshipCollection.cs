namespace MOM.Domain.Common.Relationship.isa95.PhysicalAsset
{
    public class PhysicalAssetDefinedByRelationshipCollection : RelationshipCollection<PhysicalAssetDefinedByRelationship, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAssetClass>
    {
        public PhysicalAssetDefinedByRelationshipCollection(IEnumerable<PhysicalAssetDefinedByRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PhysicalAssetDefinedByRelationship>())
        {
        }
    }
}