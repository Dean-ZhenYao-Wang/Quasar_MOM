namespace MOM.Domain.Common.Relationship.isa95.OperationsCapability
{
    public class OperationsCapabilityIsACollectionOfPhysicalAssetRelationshipCollection : RelationshipCollection<OperationsCapabilityIsACollectionOfPhysicalAssetRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsCapability.PhysicalAssetCapability>
    {
        public OperationsCapabilityIsACollectionOfPhysicalAssetRelationshipCollection(IEnumerable<OperationsCapabilityIsACollectionOfPhysicalAssetRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsCapabilityIsACollectionOfPhysicalAssetRelationship>())
        {
        }
    }
}