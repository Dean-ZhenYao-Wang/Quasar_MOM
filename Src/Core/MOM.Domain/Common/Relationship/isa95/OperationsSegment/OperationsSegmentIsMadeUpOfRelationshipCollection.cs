namespace MOM.Domain.Common.Relationship.isa95.OperationsSegment
{
    public class OperationsSegmentIsMadeUpOfRelationshipCollection : RelationshipCollection<OperationsSegmentIsMadeUpOfRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsSegment>
    {
        public OperationsSegmentIsMadeUpOfRelationshipCollection(IEnumerable<OperationsSegmentIsMadeUpOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsSegmentIsMadeUpOfRelationship>())
        {
        }
    }
}