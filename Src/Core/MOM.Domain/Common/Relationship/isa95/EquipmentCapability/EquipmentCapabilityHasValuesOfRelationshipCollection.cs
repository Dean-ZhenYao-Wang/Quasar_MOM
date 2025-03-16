namespace MOM.Domain.Common.Relationship.isa95.EquipmentCapability
{
    public class EquipmentCapabilityHasValuesOfRelationshipCollection : RelationshipCollection<EquipmentCapabilityHasValuesOfRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsCapability.EquipmentCapabilityProperty>
    {
        public EquipmentCapabilityHasValuesOfRelationshipCollection(IEnumerable<EquipmentCapabilityHasValuesOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<EquipmentCapabilityHasValuesOfRelationship>())
        {
        }
    }
}