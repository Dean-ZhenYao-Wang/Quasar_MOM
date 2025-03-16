namespace MOM.Domain.Common.Relationship.isa95.EquipmentClass
{
    public class EquipmentClassHasPropertiesOfRelationshipCollection : RelationshipCollection<EquipmentClassHasPropertiesOfRelationship, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentClassProperty>
    {
        public EquipmentClassHasPropertiesOfRelationshipCollection(IEnumerable<EquipmentClassHasPropertiesOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<EquipmentClassHasPropertiesOfRelationship>())
        {
        }
    }
}