namespace MOM.Domain.Common.Relationship.isa95.OperationsSegment
{
    public class OperationsSegmentHasAnExecutionDependencyOnSegmentRelationshipCollection : RelationshipCollection<OperationsSegmentHasAnExecutionDependencyOnSegmentRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsSegmentDependency>
    {
        public OperationsSegmentHasAnExecutionDependencyOnSegmentRelationshipCollection(IEnumerable<OperationsSegmentHasAnExecutionDependencyOnSegmentRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsSegmentHasAnExecutionDependencyOnSegmentRelationship>())
        {
        }
    }
}