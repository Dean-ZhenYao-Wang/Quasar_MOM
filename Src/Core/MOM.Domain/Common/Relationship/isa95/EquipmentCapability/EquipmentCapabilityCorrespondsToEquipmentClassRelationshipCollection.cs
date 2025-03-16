namespace MOM.Domain.Common.Relationship.isa95.EquipmentCapability
{
    public class EquipmentCapabilityCorrespondsToEquipmentClassRelationshipCollection : RelationshipCollection<EquipmentCapabilityCorrespondsToEquipmentClassRelationship, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentClass>
    {
        public EquipmentCapabilityCorrespondsToEquipmentClassRelationshipCollection(IEnumerable<EquipmentCapabilityCorrespondsToEquipmentClassRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<EquipmentCapabilityCorrespondsToEquipmentClassRelationship>())
        {
        }
    }
}