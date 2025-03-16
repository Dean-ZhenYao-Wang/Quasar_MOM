namespace MOM.Domain.Common.Relationship.isa95.WorkCapability
{
    public class WorkCapabilityIsACollectionOfEquipmentRelationshipCollection : RelationshipCollection<WorkCapabilityIsACollectionOfEquipmentRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsCapability.EquipmentCapability>
    {
        public WorkCapabilityIsACollectionOfEquipmentRelationshipCollection(IEnumerable<WorkCapabilityIsACollectionOfEquipmentRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkCapabilityIsACollectionOfEquipmentRelationship>())
        {
        }
    }
}