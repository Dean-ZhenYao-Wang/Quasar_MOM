namespace MOM.Domain.Common.Relationship.isa95.EquipmentSpecification
{
    public class EquipmentSpecificationCorrespondsToEquipmentClassRelationshipCollection : RelationshipCollection<EquipmentSpecificationCorrespondsToEquipmentClassRelationship, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentClass>
    {
        public EquipmentSpecificationCorrespondsToEquipmentClassRelationshipCollection(IEnumerable<EquipmentSpecificationCorrespondsToEquipmentClassRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<EquipmentSpecificationCorrespondsToEquipmentClassRelationship>())
        {
        }
    }
}