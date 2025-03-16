namespace MOM.Domain.Common.Relationship.isa95.ProcessSegment
{
    public class ProcessSegmentIncludesPropertiesOfRelationshipCollection : RelationshipCollection<ProcessSegmentIncludesPropertiesOfRelationship, Domain.isa95.CommonObjectModels.Part2.ProcessSegment.ProcessSegment>
    {
        public ProcessSegmentIncludesPropertiesOfRelationshipCollection(IEnumerable<ProcessSegmentIncludesPropertiesOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<ProcessSegmentIncludesPropertiesOfRelationship>())
        {
        }
    }
}