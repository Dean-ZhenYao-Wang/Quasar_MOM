namespace MOM.Domain.Common.Relationship.isa95.WorkSchedule
{
    public class WorkScheduleIsMadeUpOfScheduleRelationshipCollection : RelationshipCollection<WorkScheduleIsMadeUpOfScheduleRelationship, Domain.isa95.CommonObjectModels.Part4.WorkSchedule.WorkSchedule>
    {
        public WorkScheduleIsMadeUpOfScheduleRelationshipCollection(IEnumerable<WorkScheduleIsMadeUpOfScheduleRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkScheduleIsMadeUpOfScheduleRelationship>())
        {
        }
    }
}