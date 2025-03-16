namespace MOM.Domain.Common.Relationship.isa95.EquipmentClassProperty
{
    public class EquipmentClassPropertyContainsRelationshipCollection : RelationshipCollection<EquipmentClassPropertyContainsRelationship, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentClassProperty>
    {
        public EquipmentClassPropertyContainsRelationshipCollection(IEnumerable<EquipmentClassPropertyContainsRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<EquipmentClassPropertyContainsRelationship>())
        {
        }
    }
}