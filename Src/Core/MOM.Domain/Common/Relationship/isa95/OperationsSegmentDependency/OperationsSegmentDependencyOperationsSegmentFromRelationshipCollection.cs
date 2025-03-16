namespace MOM.Domain.Common.Relationship.isa95.OperationsSegmentDependency
{
    public class OperationsSegmentDependencyOperationsSegmentFromRelationshipCollection : RelationshipCollection<OperationsSegmentDependencyOperationsSegmentFromRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsSegment>
    {
        public OperationsSegmentDependencyOperationsSegmentFromRelationshipCollection(IEnumerable<OperationsSegmentDependencyOperationsSegmentFromRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsSegmentDependencyOperationsSegmentFromRelationship>())
        {
        }
    }
}