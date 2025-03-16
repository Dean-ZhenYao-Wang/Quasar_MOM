namespace MOM.Domain.Common.Relationship.isa95.ProcessSegment
{
    public class ProcessSegmentHasAnExecutionDependencyOnRelationshipCollection : RelationshipCollection<ProcessSegmentHasAnExecutionDependencyOnRelationship, Domain.isa95.CommonObjectModels.Part2.ProcessSegment.ProcessSegment>
    {
        public ProcessSegmentHasAnExecutionDependencyOnRelationshipCollection(IEnumerable<ProcessSegmentHasAnExecutionDependencyOnRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<ProcessSegmentHasAnExecutionDependencyOnRelationship>())
        {
        }
    }
}