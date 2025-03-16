namespace MOM.Domain.Common.Relationship.isa95.SegmentRequirement
{
    public class SegmentRequirementContainsParameterRelationshipCollection : RelationshipCollection<SegmentRequirementContainsParameterRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.SegmentParameter>
    {
        public SegmentRequirementContainsParameterRelationshipCollection(IEnumerable<SegmentRequirementContainsParameterRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<SegmentRequirementContainsParameterRelationship>())
        {
        }
    }
}