namespace MOM.Domain.Common.Relationship.isa95.SegmentRequirement
{
    public class SegmentRequirementCorrespondsToAProcessSegmentRelationshipCollection : RelationshipCollection<SegmentRequirementCorrespondsToAProcessSegmentRelationship, Domain.isa95.CommonObjectModels.Part2.ProcessSegment.ProcessSegment>
    {
        public SegmentRequirementCorrespondsToAProcessSegmentRelationshipCollection(IEnumerable<SegmentRequirementCorrespondsToAProcessSegmentRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<SegmentRequirementCorrespondsToAProcessSegmentRelationship>())
        {
        }
    }
}