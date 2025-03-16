namespace MOM.Domain.Common.Relationship.isa95.WorkRequest
{
    public class WorkRequestIsMadeUpOfJobRelationshipCollection : RelationshipCollection<WorkRequestIsMadeUpOfJobRelationship, Domain.isa95.CommonObjectModels.Part4.WorkSchedule.JobOrder>
    {
        public WorkRequestIsMadeUpOfJobRelationshipCollection(IEnumerable<WorkRequestIsMadeUpOfJobRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkRequestIsMadeUpOfJobRelationship>())
        {
        }
    }
}