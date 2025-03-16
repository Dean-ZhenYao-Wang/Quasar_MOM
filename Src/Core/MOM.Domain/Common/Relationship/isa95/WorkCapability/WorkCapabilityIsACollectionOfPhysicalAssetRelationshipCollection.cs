namespace MOM.Domain.Common.Relationship.isa95.WorkCapability
{
    public class WorkCapabilityIsACollectionOfPhysicalAssetRelationshipCollection : RelationshipCollection<WorkCapabilityIsACollectionOfPhysicalAssetRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsCapability.PhysicalAssetCapability>
    {
        public WorkCapabilityIsACollectionOfPhysicalAssetRelationshipCollection(IEnumerable<WorkCapabilityIsACollectionOfPhysicalAssetRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkCapabilityIsACollectionOfPhysicalAssetRelationship>())
        {
        }
    }
}