namespace MOM.Domain.Common.Relationship.isa95.EquipmentSegmentSpecification
{
    public class EquipmentSegmentSpecificationCorrespondsToEquipmentRelationshipCollection : RelationshipCollection<EquipmentSegmentSpecificationCorrespondsToEquipmentRelationship, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.Equipment>
    {
        public EquipmentSegmentSpecificationCorrespondsToEquipmentRelationshipCollection(IEnumerable<EquipmentSegmentSpecificationCorrespondsToEquipmentRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<EquipmentSegmentSpecificationCorrespondsToEquipmentRelationship>())
        {
        }
    }
}