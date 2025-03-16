namespace MOM.Domain.Common.Relationship.isa95.EquipmentProperty
{
    public class EquipmentPropertyContainsRelationshipCollection : RelationshipCollection<EquipmentPropertyContainsRelationship, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentProperty>
    {
        public EquipmentPropertyContainsRelationshipCollection(IEnumerable<EquipmentPropertyContainsRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<EquipmentPropertyContainsRelationship>())
        {
        }
    }
}