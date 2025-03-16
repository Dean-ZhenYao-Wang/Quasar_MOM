namespace MOM.Domain.Common.Relationship.isa95.WorkRequest
{
    public class WorkRequestCorrespondsToRequirementRelationshipCollection : RelationshipCollection<WorkRequestCorrespondsToRequirementRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.SegmentRequirement>
    {
        public WorkRequestCorrespondsToRequirementRelationshipCollection(IEnumerable<WorkRequestCorrespondsToRequirementRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkRequestCorrespondsToRequirementRelationship>())
        {
        }
    }
}