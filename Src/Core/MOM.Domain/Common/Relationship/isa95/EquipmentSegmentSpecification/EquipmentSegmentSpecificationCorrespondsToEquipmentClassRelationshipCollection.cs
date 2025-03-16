namespace MOM.Domain.Common.Relationship.isa95.EquipmentSegmentSpecification
{
    public class EquipmentSegmentSpecificationCorrespondsToEquipmentClassRelationshipCollection : RelationshipCollection<EquipmentSegmentSpecificationCorrespondsToEquipmentClassRelationship, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentClass>
    {
        public EquipmentSegmentSpecificationCorrespondsToEquipmentClassRelationshipCollection(IEnumerable<EquipmentSegmentSpecificationCorrespondsToEquipmentClassRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<EquipmentSegmentSpecificationCorrespondsToEquipmentClassRelationship>())
        {
        }
    }
}