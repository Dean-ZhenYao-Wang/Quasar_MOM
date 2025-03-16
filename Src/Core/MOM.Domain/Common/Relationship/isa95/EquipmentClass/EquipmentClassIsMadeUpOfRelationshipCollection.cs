namespace MOM.Domain.Common.Relationship.isa95.EquipmentClass
{
    public class EquipmentClassIsMadeUpOfRelationshipCollection : RelationshipCollection<EquipmentClassIsMadeUpOfRelationship, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentClass>
    {
        public EquipmentClassIsMadeUpOfRelationshipCollection(IEnumerable<EquipmentClassIsMadeUpOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<EquipmentClassIsMadeUpOfRelationship>())
        {
        }
    }
}