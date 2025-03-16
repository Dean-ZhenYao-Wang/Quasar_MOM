namespace MOM.Domain.Common.Relationship.isa95.ProcessSegment
{
    public class ProcessSegmentHasAnExecutionDependencyOnSegmentRelationshipCollection : RelationshipCollection<ProcessSegmentHasAnExecutionDependencyOnSegmentRelationship, Domain.isa95.CommonObjectModels.Part2.ProcessSegment.ProcessSegmentDependency>
    {
        public ProcessSegmentHasAnExecutionDependencyOnSegmentRelationshipCollection(IEnumerable<ProcessSegmentHasAnExecutionDependencyOnSegmentRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<ProcessSegmentHasAnExecutionDependencyOnSegmentRelationship>())
        {
        }
    }
}