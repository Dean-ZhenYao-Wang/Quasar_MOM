namespace MOM.Domain.Common.Relationship.isa95.WorkCalendarEntry
{
    public class WorkCalendarEntryHasValuesOfRelationshipCollection : RelationshipCollection<WorkCalendarEntryHasValuesOfRelationship, Domain.isa95.CommonObjectModels.Part4.WorkCalendar.WorkCalendarEntryProperty>
    {
        public WorkCalendarEntryHasValuesOfRelationshipCollection(IEnumerable<WorkCalendarEntryHasValuesOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkCalendarEntryHasValuesOfRelationship>())
        {
        }
    }
}