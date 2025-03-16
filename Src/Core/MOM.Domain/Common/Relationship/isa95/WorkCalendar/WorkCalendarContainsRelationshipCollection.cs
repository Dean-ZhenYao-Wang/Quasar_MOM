namespace MOM.Domain.Common.Relationship.isa95.WorkCalendar
{
    public class WorkCalendarContainsRelationshipCollection : RelationshipCollection<WorkCalendarContainsRelationship, Domain.isa95.CommonObjectModels.Part4.WorkCalendar.WorkCalendarEntry>
    {
        public WorkCalendarContainsRelationshipCollection(IEnumerable<WorkCalendarContainsRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkCalendarContainsRelationship>())
        {
        }
    }
}