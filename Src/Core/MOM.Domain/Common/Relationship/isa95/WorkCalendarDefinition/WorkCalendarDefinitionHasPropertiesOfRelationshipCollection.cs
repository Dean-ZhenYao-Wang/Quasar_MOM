namespace MOM.Domain.Common.Relationship.isa95.WorkCalendarDefinition
{
    public class WorkCalendarDefinitionHasPropertiesOfRelationshipCollection : RelationshipCollection<WorkCalendarDefinitionHasPropertiesOfRelationship, Domain.isa95.CommonObjectModels.Part4.WorkCalendar.WorkCalendarDefinitionProperty>
    {
        public WorkCalendarDefinitionHasPropertiesOfRelationshipCollection(IEnumerable<WorkCalendarDefinitionHasPropertiesOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkCalendarDefinitionHasPropertiesOfRelationship>())
        {
        }
    }
}