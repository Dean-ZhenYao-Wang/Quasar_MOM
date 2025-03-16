namespace MOM.Domain.Common.Relationship.isa95.ProcessSegmentCapability
{
    public class ProcessSegmentCapabilityIsACollectionOfPhysicalAssetRelationshipCollection : RelationshipCollection<ProcessSegmentCapabilityIsACollectionOfPhysicalAssetRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsCapability.PhysicalAssetCapability>
    {
        public ProcessSegmentCapabilityIsACollectionOfPhysicalAssetRelationshipCollection(IEnumerable<ProcessSegmentCapabilityIsACollectionOfPhysicalAssetRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<ProcessSegmentCapabilityIsACollectionOfPhysicalAssetRelationship>())
        {
        }
    }
}