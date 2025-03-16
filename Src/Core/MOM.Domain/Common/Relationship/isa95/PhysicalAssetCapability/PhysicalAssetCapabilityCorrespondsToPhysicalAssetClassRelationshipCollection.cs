namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetCapability
{
    public class PhysicalAssetCapabilityCorrespondsToPhysicalAssetClassRelationshipCollection : RelationshipCollection<PhysicalAssetCapabilityCorrespondsToPhysicalAssetClassRelationship, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAssetClass>
    {
        public PhysicalAssetCapabilityCorrespondsToPhysicalAssetClassRelationshipCollection(IEnumerable<PhysicalAssetCapabilityCorrespondsToPhysicalAssetClassRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PhysicalAssetCapabilityCorrespondsToPhysicalAssetClassRelationship>())
        {
        }
    }
}