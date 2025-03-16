namespace MOM.Domain.Common.Relationship.isa95.OperationsRequest
{
    public class OperationsRequestIsMadeUpOfResponseRelationshipCollection : RelationshipCollection<OperationsRequestIsMadeUpOfResponseRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.RequestedSegmentResponse>
    {
        public OperationsRequestIsMadeUpOfResponseRelationshipCollection(IEnumerable<OperationsRequestIsMadeUpOfResponseRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsRequestIsMadeUpOfResponseRelationship>())
        {
        }
    }
}