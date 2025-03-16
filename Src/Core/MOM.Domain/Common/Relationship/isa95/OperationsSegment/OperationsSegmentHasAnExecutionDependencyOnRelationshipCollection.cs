namespace MOM.Domain.Common.Relationship.isa95.OperationsSegment
{
    public class OperationsSegmentHasAnExecutionDependencyOnRelationshipCollection : RelationshipCollection<OperationsSegmentHasAnExecutionDependencyOnRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsSegment>
    {
        public OperationsSegmentHasAnExecutionDependencyOnRelationshipCollection(IEnumerable<OperationsSegmentHasAnExecutionDependencyOnRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsSegmentHasAnExecutionDependencyOnRelationship>())
        {
        }
    }
}