namespace MOM.Domain.Common.Relationship.isa95.EquipmentActual
{
    public class EquipmentActualCorrespondsToEquipmentClassRelationshipCollection : RelationshipCollection<EquipmentActualCorrespondsToEquipmentClassRelationship, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentClass>
    {
        public EquipmentActualCorrespondsToEquipmentClassRelationshipCollection(IEnumerable<EquipmentActualCorrespondsToEquipmentClassRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<EquipmentActualCorrespondsToEquipmentClassRelationship>())
        {
        }
    }
}