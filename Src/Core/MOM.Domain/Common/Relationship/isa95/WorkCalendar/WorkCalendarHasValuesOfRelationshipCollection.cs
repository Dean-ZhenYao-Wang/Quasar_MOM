namespace MOM.Domain.Common.Relationship.isa95.WorkCalendar
{
    public class WorkCalendarHasValuesOfRelationshipCollection : RelationshipCollection<WorkCalendarHasValuesOfRelationship, Domain.isa95.CommonObjectModels.Part4.WorkCalendar.WorkCalendarProperty>
    {
        public WorkCalendarHasValuesOfRelationshipCollection(IEnumerable<WorkCalendarHasValuesOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkCalendarHasValuesOfRelationship>())
        {
        }
    }
}