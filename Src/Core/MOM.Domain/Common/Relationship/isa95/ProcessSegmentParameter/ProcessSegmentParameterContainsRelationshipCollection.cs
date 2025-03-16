namespace MOM.Domain.Common.Relationship.isa95.ProcessSegmentParameter
{
    public class ProcessSegmentParameterContainsRelationshipCollection : RelationshipCollection<ProcessSegmentParameterContainsRelationship, Domain.isa95.CommonObjectModels.Part2.ProcessSegment.ProcessSegmentParameter>
    {
        public ProcessSegmentParameterContainsRelationshipCollection(IEnumerable<ProcessSegmentParameterContainsRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<ProcessSegmentParameterContainsRelationship>())
        {
        }
    }
}