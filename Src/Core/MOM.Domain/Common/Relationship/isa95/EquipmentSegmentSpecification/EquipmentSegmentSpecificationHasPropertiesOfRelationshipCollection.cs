namespace MOM.Domain.Common.Relationship.isa95.EquipmentSegmentSpecification
{
    public class EquipmentSegmentSpecificationHasPropertiesOfRelationshipCollection : RelationshipCollection<EquipmentSegmentSpecificationHasPropertiesOfRelationship, Domain.isa95.CommonObjectModels.Part2.ProcessSegment.EquipmentSegmentSpecificationProperty>
    {
        public EquipmentSegmentSpecificationHasPropertiesOfRelationshipCollection(IEnumerable<EquipmentSegmentSpecificationHasPropertiesOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<EquipmentSegmentSpecificationHasPropertiesOfRelationship>())
        {
        }
    }
}