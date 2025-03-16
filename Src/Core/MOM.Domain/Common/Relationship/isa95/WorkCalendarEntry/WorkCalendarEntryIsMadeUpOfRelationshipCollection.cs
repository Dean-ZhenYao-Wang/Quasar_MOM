namespace MOM.Domain.Common.Relationship.isa95.WorkCalendarEntry
{
    public class WorkCalendarEntryIsMadeUpOfRelationshipCollection : RelationshipCollection<WorkCalendarEntryIsMadeUpOfRelationship, Domain.isa95.CommonObjectModels.Part4.WorkCalendar.WorkCalendarEntry>
    {
        public WorkCalendarEntryIsMadeUpOfRelationshipCollection(IEnumerable<WorkCalendarEntryIsMadeUpOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkCalendarEntryIsMadeUpOfRelationship>())
        {
        }
    }
}