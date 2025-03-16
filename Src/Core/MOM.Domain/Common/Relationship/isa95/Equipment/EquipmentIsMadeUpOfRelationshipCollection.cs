namespace MOM.Domain.Common.Relationship.isa95.Equipment
{
    public class EquipmentIsMadeUpOfRelationshipCollection : RelationshipCollection<EquipmentIsMadeUpOfRelationship, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.Equipment>
    {
        public EquipmentIsMadeUpOfRelationshipCollection(IEnumerable<EquipmentIsMadeUpOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<EquipmentIsMadeUpOfRelationship>())
        {
        }
    }
}