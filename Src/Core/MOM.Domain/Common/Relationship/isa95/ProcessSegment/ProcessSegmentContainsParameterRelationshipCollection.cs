namespace MOM.Domain.Common.Relationship.isa95.ProcessSegment
{
    public class ProcessSegmentContainsParameterRelationshipCollection : RelationshipCollection<ProcessSegmentContainsParameterRelationship, Domain.isa95.CommonObjectModels.Part2.ProcessSegment.ProcessSegmentParameter>
    {
        public ProcessSegmentContainsParameterRelationshipCollection(IEnumerable<ProcessSegmentContainsParameterRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<ProcessSegmentContainsParameterRelationship>())
        {
        }
    }
}