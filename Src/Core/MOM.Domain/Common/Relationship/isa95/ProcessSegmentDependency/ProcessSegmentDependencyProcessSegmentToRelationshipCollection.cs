namespace MOM.Domain.Common.Relationship.isa95.ProcessSegmentDependency
{
    public class ProcessSegmentDependencyProcessSegmentToRelationshipCollection : RelationshipCollection<ProcessSegmentDependencyProcessSegmentToRelationship, Domain.isa95.CommonObjectModels.Part2.ProcessSegment.ProcessSegment>
    {
        public ProcessSegmentDependencyProcessSegmentToRelationshipCollection(IEnumerable<ProcessSegmentDependencyProcessSegmentToRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<ProcessSegmentDependencyProcessSegmentToRelationship>())
        {
        }
    }
}