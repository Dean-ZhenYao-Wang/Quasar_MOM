namespace MOM.Domain.Common.Relationship.isa95.WorkCalendarDefinitionEntryProperty
{
    public class WorkCalendarDefinitionEntryPropertyContainsRelationshipCollection : RelationshipCollection<WorkCalendarDefinitionEntryPropertyContainsRelationship, Domain.isa95.CommonObjectModels.Part4.WorkCalendar.WorkCalendarDefinitionEntryProperty>
    {
        public WorkCalendarDefinitionEntryPropertyContainsRelationshipCollection(IEnumerable<WorkCalendarDefinitionEntryPropertyContainsRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkCalendarDefinitionEntryPropertyContainsRelationship>())
        {
        }
    }
}