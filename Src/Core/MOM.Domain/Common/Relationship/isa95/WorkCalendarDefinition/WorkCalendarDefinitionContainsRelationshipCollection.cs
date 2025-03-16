namespace MOM.Domain.Common.Relationship.isa95.WorkCalendarDefinition
{
    public class WorkCalendarDefinitionContainsRelationshipCollection : RelationshipCollection<WorkCalendarDefinitionContainsRelationship, Domain.isa95.CommonObjectModels.Part4.WorkCalendar.WorkCalendarDefinitionEntry>
    {
        public WorkCalendarDefinitionContainsRelationshipCollection(IEnumerable<WorkCalendarDefinitionContainsRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkCalendarDefinitionContainsRelationship>())
        {
        }
    }
}