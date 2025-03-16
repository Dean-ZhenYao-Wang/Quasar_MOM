namespace MOM.Domain.Common.Relationship.isa95.WorkCalendarEntryProperty
{
    public class WorkCalendarEntryPropertyMapsToRelationshipCollection : RelationshipCollection<WorkCalendarEntryPropertyMapsToRelationship, Domain.isa95.CommonObjectModels.Part4.WorkCalendar.WorkCalendarDefinitionEntryProperty>
    {
        public WorkCalendarEntryPropertyMapsToRelationshipCollection(IEnumerable<WorkCalendarEntryPropertyMapsToRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkCalendarEntryPropertyMapsToRelationship>())
        {
        }
    }
}