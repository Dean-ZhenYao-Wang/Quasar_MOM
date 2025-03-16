namespace MOM.Domain.Common.Relationship.isa95.EquipmentSpecification
{
    public class EquipmentSpecificationCorrespondsToEquipmentRelationshipCollection : RelationshipCollection<EquipmentSpecificationCorrespondsToEquipmentRelationship, MOM.Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.Equipment>
    {
        public EquipmentSpecificationCorrespondsToEquipmentRelationshipCollection(IEnumerable<EquipmentSpecificationCorrespondsToEquipmentRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<EquipmentSpecificationCorrespondsToEquipmentRelationship>())
        {
        }
    }
}