namespace MOM.Domain.Common.Relationship.isa95.ProcessSegment
{
    public class ProcessSegmentContainsEquipmentSpecificationRelationshipCollection : RelationshipCollection<ProcessSegmentContainsEquipmentSpecificationRelationship, Domain.isa95.CommonObjectModels.Part2.ProcessSegment.EquipmentSegmentSpecification>
    {
        public ProcessSegmentContainsEquipmentSpecificationRelationshipCollection(IEnumerable<ProcessSegmentContainsEquipmentSpecificationRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<ProcessSegmentContainsEquipmentSpecificationRelationship>())
        {
        }
    }
}