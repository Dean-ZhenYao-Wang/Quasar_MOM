namespace MOM.Domain.Common.Relationship.isa95.SegmentParameter
{
    public class SegmentParameterContainsRelationshipCollection : RelationshipCollection<SegmentParameterContainsRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.SegmentParameter>
    {
        public SegmentParameterContainsRelationshipCollection(IEnumerable<SegmentParameterContainsRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<SegmentParameterContainsRelationship>())
        {
        }
    }
}