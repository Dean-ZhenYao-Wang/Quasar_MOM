namespace MOM.Domain.Common.Relationship.isa95.EquipmentActual
{
    public class EquipmentActualCorrespondsToEquipmentRelationshipCollection : RelationshipCollection<EquipmentActualCorrespondsToEquipmentRelationship, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.Equipment>
    {
        public EquipmentActualCorrespondsToEquipmentRelationshipCollection(IEnumerable<EquipmentActualCorrespondsToEquipmentRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<EquipmentActualCorrespondsToEquipmentRelationship>())
        {
        }
    }
}