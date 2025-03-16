namespace MOM.Domain.Common.Relationship.isa95.EquipmentCapability
{
    public class EquipmentCapabilityIsMadeUpOfRelationshipCollection : RelationshipCollection<EquipmentCapabilityIsMadeUpOfRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsCapability.EquipmentCapability>
    {
        public EquipmentCapabilityIsMadeUpOfRelationshipCollection(IEnumerable<EquipmentCapabilityIsMadeUpOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<EquipmentCapabilityIsMadeUpOfRelationship>())
        {
        }
    }
}