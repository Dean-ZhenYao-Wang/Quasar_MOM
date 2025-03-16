namespace MOM.Domain.Common.Relationship.isa95.ProcessSegmentDependency
{
    public class ProcessSegmentDependencyProcessSegmentFromRelationshipCollection : RelationshipCollection<ProcessSegmentDependencyProcessSegmentFromRelationship, Domain.isa95.CommonObjectModels.Part2.ProcessSegment.ProcessSegment>
    {
        public ProcessSegmentDependencyProcessSegmentFromRelationshipCollection(IEnumerable<ProcessSegmentDependencyProcessSegmentFromRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<ProcessSegmentDependencyProcessSegmentFromRelationship>())
        {
        }
    }
}