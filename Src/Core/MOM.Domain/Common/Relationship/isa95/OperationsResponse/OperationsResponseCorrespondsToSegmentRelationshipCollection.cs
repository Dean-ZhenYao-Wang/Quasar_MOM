namespace MOM.Domain.Common.Relationship.isa95.OperationsResponse
{
    public class OperationsResponseCorrespondsToSegmentRelationshipCollection : RelationshipCollection<OperationsResponseCorrespondsToSegmentRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsSegment>
    {
        public OperationsResponseCorrespondsToSegmentRelationshipCollection(IEnumerable<OperationsResponseCorrespondsToSegmentRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsResponseCorrespondsToSegmentRelationship>())
        {
        }
    }
}