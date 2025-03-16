namespace MOM.Domain.Common.Relationship.isa95.WorkMasterCapability
{
    public class WorkMasterCapabilityIsACollectionOfMaterialRelationshipCollection : RelationshipCollection<WorkMasterCapabilityIsACollectionOfMaterialRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsCapability.MaterialCapability>
    {
        public WorkMasterCapabilityIsACollectionOfMaterialRelationshipCollection(IEnumerable<WorkMasterCapabilityIsACollectionOfMaterialRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkMasterCapabilityIsACollectionOfMaterialRelationship>())
        {
        }
    }
}