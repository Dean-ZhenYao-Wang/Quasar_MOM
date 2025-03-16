namespace MOM.Domain.Common.Relationship.isa95.WorkSchedule
{
    public class WorkScheduleIsMadeUpOfRequestRelationshipCollection : RelationshipCollection<WorkScheduleIsMadeUpOfRequestRelationship, Domain.isa95.CommonObjectModels.Part4.WorkSchedule.WorkRequest>
    {
        public WorkScheduleIsMadeUpOfRequestRelationshipCollection(IEnumerable<WorkScheduleIsMadeUpOfRequestRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkScheduleIsMadeUpOfRequestRelationship>())
        {
        }
    }
}