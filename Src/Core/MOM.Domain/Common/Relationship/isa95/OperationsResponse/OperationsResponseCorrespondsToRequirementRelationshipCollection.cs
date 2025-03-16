namespace MOM.Domain.Common.Relationship.isa95.OperationsResponse
{
    public class OperationsResponseCorrespondsToRequirementRelationshipCollection : RelationshipCollection<OperationsResponseCorrespondsToRequirementRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.SegmentRequirement>
    {
        public OperationsResponseCorrespondsToRequirementRelationshipCollection(IEnumerable<OperationsResponseCorrespondsToRequirementRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsResponseCorrespondsToRequirementRelationship>())
        {
        }
    }
}