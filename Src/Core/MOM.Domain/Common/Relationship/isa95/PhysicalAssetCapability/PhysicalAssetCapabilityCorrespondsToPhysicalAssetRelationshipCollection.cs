namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetCapability
{
    public class PhysicalAssetCapabilityCorrespondsToPhysicalAssetRelationshipCollection : RelationshipCollection<PhysicalAssetCapabilityCorrespondsToPhysicalAssetRelationship, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAsset>
    {
        public PhysicalAssetCapabilityCorrespondsToPhysicalAssetRelationshipCollection(IEnumerable<PhysicalAssetCapabilityCorrespondsToPhysicalAssetRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PhysicalAssetCapabilityCorrespondsToPhysicalAssetRelationship>())
        {
        }
    }
}