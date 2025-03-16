namespace MOM.Domain.Common.Relationship.isa95.RequestedSegmentResponse
{
    public class RequestedSegmentResponseCorrespondsToRequirementRelationshipCollection : RelationshipCollection<RequestedSegmentResponseCorrespondsToRequirementRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.SegmentRequirement>
    {
        public RequestedSegmentResponseCorrespondsToRequirementRelationshipCollection(IEnumerable<RequestedSegmentResponseCorrespondsToRequirementRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<RequestedSegmentResponseCorrespondsToRequirementRelationship>())
        {
        }
    }
}