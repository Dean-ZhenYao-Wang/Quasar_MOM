namespace MOM.Domain.Common.Relationship.isa95.WorkCalendar
{
    public class WorkCalendarDefinedByRelationshipCollection : RelationshipCollection<WorkCalendarDefinedByRelationship, Domain.isa95.CommonObjectModels.Part4.WorkCalendar.WorkCalendarDefinition>
    {
        public WorkCalendarDefinedByRelationshipCollection(IEnumerable<WorkCalendarDefinedByRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkCalendarDefinedByRelationship>())
        {
        }
    }
}