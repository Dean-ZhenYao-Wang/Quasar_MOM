namespace MOM.Domain.Common.Relationship.isa95.EquipmentSegmentSpecification
{
    public class EquipmentSegmentSpecificationIsMadeUpOfRelationshipCollection : RelationshipCollection<EquipmentSegmentSpecificationIsMadeUpOfRelationship, Domain.isa95.CommonObjectModels.Part2.ProcessSegment.EquipmentSegmentSpecification>
    {
        public EquipmentSegmentSpecificationIsMadeUpOfRelationshipCollection(IEnumerable<EquipmentSegmentSpecificationIsMadeUpOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<EquipmentSegmentSpecificationIsMadeUpOfRelationship>())
        {
        }
    }
}