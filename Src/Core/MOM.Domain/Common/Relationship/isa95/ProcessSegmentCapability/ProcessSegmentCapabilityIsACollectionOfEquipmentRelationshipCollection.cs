namespace MOM.Domain.Common.Relationship.isa95.ProcessSegmentCapability
{
    public class ProcessSegmentCapabilityIsACollectionOfEquipmentRelationshipCollection : RelationshipCollection<ProcessSegmentCapabilityIsACollectionOfEquipmentRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsCapability.EquipmentCapability>
    {
        public ProcessSegmentCapabilityIsACollectionOfEquipmentRelationshipCollection(IEnumerable<ProcessSegmentCapabilityIsACollectionOfEquipmentRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<ProcessSegmentCapabilityIsACollectionOfEquipmentRelationship>())
        {
        }
    }
}