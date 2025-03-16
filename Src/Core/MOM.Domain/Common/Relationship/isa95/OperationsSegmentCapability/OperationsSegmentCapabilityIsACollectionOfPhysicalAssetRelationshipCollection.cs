namespace MOM.Domain.Common.Relationship.isa95.OperationsSegmentCapability
{
    public class OperationsSegmentCapabilityIsACollectionOfPhysicalAssetRelationshipCollection : RelationshipCollection<OperationsSegmentCapabilityIsACollectionOfPhysicalAssetRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsCapability.PhysicalAssetCapability>
    {
        public OperationsSegmentCapabilityIsACollectionOfPhysicalAssetRelationshipCollection(IEnumerable<OperationsSegmentCapabilityIsACollectionOfPhysicalAssetRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsSegmentCapabilityIsACollectionOfPhysicalAssetRelationship>())
        {
        }
    }
}