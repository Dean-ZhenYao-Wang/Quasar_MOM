namespace MOM.Domain.Common.Relationship.isa95.OperationsRequest
{
    public class OperationsRequestCorrespondsToSegmentRelationshipCollection : RelationshipCollection<OperationsRequestCorrespondsToSegmentRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsSegment>
    {
        public OperationsRequestCorrespondsToSegmentRelationshipCollection(IEnumerable<OperationsRequestCorrespondsToSegmentRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsRequestCorrespondsToSegmentRelationship>())
        {
        }
    }
}