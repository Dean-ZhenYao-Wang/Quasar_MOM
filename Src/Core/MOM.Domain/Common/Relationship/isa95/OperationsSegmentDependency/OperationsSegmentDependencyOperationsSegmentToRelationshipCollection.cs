namespace MOM.Domain.Common.Relationship.isa95.OperationsSegmentDependency
{
    public class OperationsSegmentDependencyOperationsSegmentToRelationshipCollection : RelationshipCollection<OperationsSegmentDependencyOperationsSegmentToRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsSegment>
    {
        public OperationsSegmentDependencyOperationsSegmentToRelationshipCollection(IEnumerable<OperationsSegmentDependencyOperationsSegmentToRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsSegmentDependencyOperationsSegmentToRelationship>())
        {
        }
    }
}