namespace MOM.Domain.Common.Relationship.isa95.EquipmentCapability
{
    public class EquipmentCapabilityOperationalLocationRelRelationshipCollection : RelationshipCollection<EquipmentCapabilityOperationalLocationRelRelationship, Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation>
    {
        public EquipmentCapabilityOperationalLocationRelRelationshipCollection(IEnumerable<EquipmentCapabilityOperationalLocationRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<EquipmentCapabilityOperationalLocationRelRelationship>())
        {
        }
    }
}