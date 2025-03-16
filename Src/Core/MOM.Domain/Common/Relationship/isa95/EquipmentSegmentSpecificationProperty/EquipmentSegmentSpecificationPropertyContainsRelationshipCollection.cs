namespace MOM.Domain.Common.Relationship.isa95.EquipmentSegmentSpecificationProperty
{
    public class EquipmentSegmentSpecificationPropertyContainsRelationshipCollection : RelationshipCollection<EquipmentSegmentSpecificationPropertyContainsRelationship, Domain.isa95.CommonObjectModels.Part2.ProcessSegment.EquipmentSegmentSpecificationProperty>
    {
        public EquipmentSegmentSpecificationPropertyContainsRelationshipCollection(IEnumerable<EquipmentSegmentSpecificationPropertyContainsRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<EquipmentSegmentSpecificationPropertyContainsRelationship>())
        {
        }
    }
}