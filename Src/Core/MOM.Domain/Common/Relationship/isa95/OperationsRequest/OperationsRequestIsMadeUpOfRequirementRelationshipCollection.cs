namespace MOM.Domain.Common.Relationship.isa95.OperationsRequest
{
    public class OperationsRequestIsMadeUpOfRequirementRelationshipCollection : RelationshipCollection<OperationsRequestIsMadeUpOfRequirementRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.SegmentRequirement>
    {
        public OperationsRequestIsMadeUpOfRequirementRelationshipCollection(IEnumerable<OperationsRequestIsMadeUpOfRequirementRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsRequestIsMadeUpOfRequirementRelationship>())
        {
        }
    }
}