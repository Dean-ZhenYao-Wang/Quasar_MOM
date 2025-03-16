namespace MOM.Domain.Common.Relationship.isa95.EquipmentClass
{
    public class EquipmentClassIncludesPropertiesOfRelationshipCollection : RelationshipCollection<EquipmentClassIncludesPropertiesOfRelationship, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentClass>
    {
        public EquipmentClassIncludesPropertiesOfRelationshipCollection(IEnumerable<EquipmentClassIncludesPropertiesOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<EquipmentClassIncludesPropertiesOfRelationship>())
        {
        }
    }
}