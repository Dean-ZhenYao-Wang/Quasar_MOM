namespace MOM.Domain.Common.Relationship.isa95.WorkCalendar
{
    public class WorkCalendarHierarchyScopeRelRelationshipCollection : RelationshipCollection<WorkCalendarHierarchyScopeRelRelationship, Domain.isa95.CommonObjectModels.HierarchyScope>
    {
        public WorkCalendarHierarchyScopeRelRelationshipCollection(IEnumerable<WorkCalendarHierarchyScopeRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkCalendarHierarchyScopeRelRelationship>())
        {
        }
    }
}