namespace MOM.Domain.Common.Relationship.isa95.EquipmentCapability
{
    public class EquipmentCapabilityCorrespondsToEquipmentRelationshipCollection : RelationshipCollection<EquipmentCapabilityCorrespondsToEquipmentRelationship, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.Equipment>
    {
        public EquipmentCapabilityCorrespondsToEquipmentRelationshipCollection(IEnumerable<EquipmentCapabilityCorrespondsToEquipmentRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<EquipmentCapabilityCorrespondsToEquipmentRelationship>())
        {
        }
    }
}