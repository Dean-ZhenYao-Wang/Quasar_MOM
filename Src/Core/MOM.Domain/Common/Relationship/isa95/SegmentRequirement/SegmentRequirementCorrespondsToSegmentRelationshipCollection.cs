namespace MOM.Domain.Common.Relationship.isa95.SegmentRequirement
{
    public class SegmentRequirementCorrespondsToSegmentRelationshipCollection : RelationshipCollection<SegmentRequirementCorrespondsToSegmentRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsSegment>
    {
        public SegmentRequirementCorrespondsToSegmentRelationshipCollection(IEnumerable<SegmentRequirementCorrespondsToSegmentRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<SegmentRequirementCorrespondsToSegmentRelationship>())
        {
        }
    }
}