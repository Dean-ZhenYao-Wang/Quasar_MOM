namespace MOM.Domain.Common.Relationship.isa95.WorkCalendarEntryProperty
{
    public class WorkCalendarEntryPropertyContainsRelationshipCollection : RelationshipCollection<WorkCalendarEntryPropertyContainsRelationship, Domain.isa95.CommonObjectModels.Part4.WorkCalendar.WorkCalendarEntryProperty>
    {
        public WorkCalendarEntryPropertyContainsRelationshipCollection(IEnumerable<WorkCalendarEntryPropertyContainsRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkCalendarEntryPropertyContainsRelationship>())
        {
        }
    }
}