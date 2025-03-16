namespace MOM.Domain.Common.Relationship.isa95.SegmentResponse
{
    public class SegmentResponseCorrespondsToRequirementRelationshipCollection : RelationshipCollection<SegmentResponseCorrespondsToRequirementRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.SegmentRequirement>
    {
        public SegmentResponseCorrespondsToRequirementRelationshipCollection(IEnumerable<SegmentResponseCorrespondsToRequirementRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<SegmentResponseCorrespondsToRequirementRelationship>())
        {
        }
    }
}