namespace MOM.Domain.Common.Relationship.isa95.Equipment
{
    public class EquipmentDefinedByRelationshipCollection : RelationshipCollection<EquipmentDefinedByRelationship, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentClass>
    {
        public EquipmentDefinedByRelationshipCollection(IEnumerable<EquipmentDefinedByRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<EquipmentDefinedByRelationship>())
        {
        }
    }
}