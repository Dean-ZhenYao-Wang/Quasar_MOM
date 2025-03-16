namespace MOM.Domain.Common.Relationship.isa95.ProcessSegment
{
    public class ProcessSegmentIsMadeUpOfRelationshipCollection : RelationshipCollection<ProcessSegmentIsMadeUpOfRelationship, Domain.isa95.CommonObjectModels.Part2.ProcessSegment.ProcessSegment>
    {
        public ProcessSegmentIsMadeUpOfRelationshipCollection(IEnumerable<ProcessSegmentIsMadeUpOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<ProcessSegmentIsMadeUpOfRelationship>())
        {
        }
    }
}