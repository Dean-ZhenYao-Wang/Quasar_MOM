namespace MOM.Domain.Common.Relationship.isa95.JobOrder
{
    public class JobOrderCorrespondsToRequirementRelationshipCollection : RelationshipCollection<JobOrderCorrespondsToRequirementRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.SegmentRequirement>
    {
        public JobOrderCorrespondsToRequirementRelationshipCollection(IEnumerable<JobOrderCorrespondsToRequirementRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<JobOrderCorrespondsToRequirementRelationship>())
        {
        }
    }
}