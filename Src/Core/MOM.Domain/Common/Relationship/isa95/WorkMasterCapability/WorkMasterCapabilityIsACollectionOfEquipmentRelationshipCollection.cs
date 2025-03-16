namespace MOM.Domain.Common.Relationship.isa95.WorkMasterCapability
{
    public class WorkMasterCapabilityIsACollectionOfEquipmentRelationshipCollection : RelationshipCollection<WorkMasterCapabilityIsACollectionOfEquipmentRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsCapability.EquipmentCapability>
    {
        public WorkMasterCapabilityIsACollectionOfEquipmentRelationshipCollection(IEnumerable<WorkMasterCapabilityIsACollectionOfEquipmentRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkMasterCapabilityIsACollectionOfEquipmentRelationship>())
        {
        }
    }
}