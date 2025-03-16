namespace MOM.Domain.Common.Relationship.isa95.EquipmentProperty
{
    public class EquipmentPropertyMapsToRelationshipCollection : RelationshipCollection<EquipmentPropertyMapsToRelationship, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentClassProperty>
    {
        public EquipmentPropertyMapsToRelationshipCollection(IEnumerable<EquipmentPropertyMapsToRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<EquipmentPropertyMapsToRelationship>())
        {
        }
    }
}