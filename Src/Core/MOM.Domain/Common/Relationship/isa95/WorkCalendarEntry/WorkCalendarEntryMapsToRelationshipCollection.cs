namespace MOM.Domain.Common.Relationship.isa95.WorkCalendarEntry
{
    public class WorkCalendarEntryMapsToRelationshipCollection : RelationshipCollection<WorkCalendarEntryMapsToRelationship, Domain.isa95.CommonObjectModels.Part4.WorkCalendar.WorkCalendarDefinitionEntry>
    {
        public WorkCalendarEntryMapsToRelationshipCollection(IEnumerable<WorkCalendarEntryMapsToRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkCalendarEntryMapsToRelationship>())
        {
        }
    }
}