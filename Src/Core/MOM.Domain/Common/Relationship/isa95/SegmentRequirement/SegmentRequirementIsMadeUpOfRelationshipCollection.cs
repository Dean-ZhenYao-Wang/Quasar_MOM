namespace MOM.Domain.Common.Relationship.isa95.SegmentRequirement
{
    public class SegmentRequirementIsMadeUpOfRelationshipCollection : RelationshipCollection<SegmentRequirementIsMadeUpOfRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.SegmentRequirement>
    {
        public SegmentRequirementIsMadeUpOfRelationshipCollection(IEnumerable<SegmentRequirementIsMadeUpOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<SegmentRequirementIsMadeUpOfRelationship>())
        {
        }
    }
}