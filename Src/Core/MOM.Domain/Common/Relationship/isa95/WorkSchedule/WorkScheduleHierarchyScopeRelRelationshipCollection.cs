namespace MOM.Domain.Common.Relationship.isa95.WorkSchedule
{
    public class WorkScheduleHierarchyScopeRelRelationshipCollection : RelationshipCollection<WorkScheduleHierarchyScopeRelRelationship, Domain.isa95.CommonObjectModels.HierarchyScope>
    {
        public WorkScheduleHierarchyScopeRelRelationshipCollection(IEnumerable<WorkScheduleHierarchyScopeRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkScheduleHierarchyScopeRelRelationship>())
        {
        }
    }
}