namespace MOM.Domain.Common.Relationship.isa95.OperationsCapability
{
    public class OperationsCapabilityIsACollectionOfEquipmentRelationshipCollection : RelationshipCollection<OperationsCapabilityIsACollectionOfEquipmentRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsCapability.EquipmentCapability>
    {
        public OperationsCapabilityIsACollectionOfEquipmentRelationshipCollection(IEnumerable<OperationsCapabilityIsACollectionOfEquipmentRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsCapabilityIsACollectionOfEquipmentRelationship>())
        {
        }
    }
}