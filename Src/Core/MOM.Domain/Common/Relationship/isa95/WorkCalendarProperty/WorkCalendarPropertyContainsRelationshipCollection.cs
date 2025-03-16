namespace MOM.Domain.Common.Relationship.isa95.WorkCalendarProperty
{
    public class WorkCalendarPropertyContainsRelationshipCollection : RelationshipCollection<WorkCalendarPropertyContainsRelationship, Domain.isa95.CommonObjectModels.Part4.WorkCalendar.WorkCalendarProperty>
    {
        public WorkCalendarPropertyContainsRelationshipCollection(IEnumerable<WorkCalendarPropertyContainsRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkCalendarPropertyContainsRelationship>())
        {
        }
    }
}