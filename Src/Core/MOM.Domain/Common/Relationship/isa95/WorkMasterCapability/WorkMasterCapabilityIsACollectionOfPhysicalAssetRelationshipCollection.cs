namespace MOM.Domain.Common.Relationship.isa95.WorkMasterCapability
{
    public class WorkMasterCapabilityIsACollectionOfPhysicalAssetRelationshipCollection : RelationshipCollection<WorkMasterCapabilityIsACollectionOfPhysicalAssetRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsCapability.PhysicalAssetCapability>
    {
        public WorkMasterCapabilityIsACollectionOfPhysicalAssetRelationshipCollection(IEnumerable<WorkMasterCapabilityIsACollectionOfPhysicalAssetRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkMasterCapabilityIsACollectionOfPhysicalAssetRelationship>())
        {
        }
    }
}