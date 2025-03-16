namespace MOM.Domain.Common.Relationship.isa95.Equipment
{
    public class EquipmentHasValuesOfRelationshipCollection : RelationshipCollection<EquipmentHasValuesOfRelationship, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentProperty>
    {
        public EquipmentHasValuesOfRelationshipCollection(IEnumerable<EquipmentHasValuesOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<EquipmentHasValuesOfRelationship>())
        {
        }
    }
}