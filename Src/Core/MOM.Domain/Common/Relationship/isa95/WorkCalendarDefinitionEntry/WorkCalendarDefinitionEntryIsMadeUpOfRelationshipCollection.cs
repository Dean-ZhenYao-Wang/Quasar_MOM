namespace MOM.Domain.Common.Relationship.isa95.WorkCalendarDefinitionEntry
{
    public class WorkCalendarDefinitionEntryIsMadeUpOfRelationshipCollection : RelationshipCollection<WorkCalendarDefinitionEntryIsMadeUpOfRelationship, Domain.isa95.CommonObjectModels.Part4.WorkCalendar.WorkCalendarDefinitionEntry>
    {
        public WorkCalendarDefinitionEntryIsMadeUpOfRelationshipCollection(IEnumerable<WorkCalendarDefinitionEntryIsMadeUpOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkCalendarDefinitionEntryIsMadeUpOfRelationship>())
        {
        }
    }
}