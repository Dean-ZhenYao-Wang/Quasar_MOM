namespace MOM.Domain.Common.Relationship.isa95.EquipmentCapabilityProperty
{
    public class EquipmentCapabilityPropertyContainsRelationshipCollection : RelationshipCollection<EquipmentCapabilityPropertyContainsRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsCapability.EquipmentCapabilityProperty>
    {
        public EquipmentCapabilityPropertyContainsRelationshipCollection(IEnumerable<EquipmentCapabilityPropertyContainsRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<EquipmentCapabilityPropertyContainsRelationship>())
        {
        }
    }
}