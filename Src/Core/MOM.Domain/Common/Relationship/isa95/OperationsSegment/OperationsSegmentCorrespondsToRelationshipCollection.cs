namespace MOM.Domain.Common.Relationship.isa95.OperationsSegment
{
    public class OperationsSegmentCorrespondsToRelationshipCollection : RelationshipCollection<OperationsSegmentCorrespondsToRelationship, Domain.isa95.CommonObjectModels.Part2.ProcessSegment.ProcessSegment>
    {
        public OperationsSegmentCorrespondsToRelationshipCollection(IEnumerable<OperationsSegmentCorrespondsToRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsSegmentCorrespondsToRelationship>())
        {
        }
    }
}