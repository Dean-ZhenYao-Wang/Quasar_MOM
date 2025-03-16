namespace MOM.Domain.Common.Relationship.isa95.WorkCalendarDefinitionEntry
{
    public class WorkCalendarDefinitionEntryHasPropertiesOfRelationshipCollection : RelationshipCollection<WorkCalendarDefinitionEntryHasPropertiesOfRelationship, Domain.isa95.CommonObjectModels.Part4.WorkCalendar.WorkCalendarDefinitionEntryProperty>
    {
        public WorkCalendarDefinitionEntryHasPropertiesOfRelationshipCollection(IEnumerable<WorkCalendarDefinitionEntryHasPropertiesOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkCalendarDefinitionEntryHasPropertiesOfRelationship>())
        {
        }
    }
}