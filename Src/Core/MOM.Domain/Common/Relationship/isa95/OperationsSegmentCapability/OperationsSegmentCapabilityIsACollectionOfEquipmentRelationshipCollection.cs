namespace MOM.Domain.Common.Relationship.isa95.OperationsSegmentCapability
{
    public class OperationsSegmentCapabilityIsACollectionOfEquipmentRelationshipCollection : RelationshipCollection<OperationsSegmentCapabilityIsACollectionOfEquipmentRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsCapability.EquipmentCapability>
    {
        public OperationsSegmentCapabilityIsACollectionOfEquipmentRelationshipCollection(IEnumerable<OperationsSegmentCapabilityIsACollectionOfEquipmentRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsSegmentCapabilityIsACollectionOfEquipmentRelationship>())
        {
        }
    }
}