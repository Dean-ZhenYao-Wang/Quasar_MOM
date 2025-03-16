namespace MOM.Domain.Common.Relationship.isa95.WorkCalendarDefinitionProperty
{
    public class WorkCalendarDefinitionPropertyContainsRelationshipCollection : RelationshipCollection<WorkCalendarDefinitionPropertyContainsRelationship, Domain.isa95.CommonObjectModels.Part4.WorkCalendar.WorkCalendarDefinitionProperty>
    {
        public WorkCalendarDefinitionPropertyContainsRelationshipCollection(IEnumerable<WorkCalendarDefinitionPropertyContainsRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkCalendarDefinitionPropertyContainsRelationship>())
        {
        }
    }
}