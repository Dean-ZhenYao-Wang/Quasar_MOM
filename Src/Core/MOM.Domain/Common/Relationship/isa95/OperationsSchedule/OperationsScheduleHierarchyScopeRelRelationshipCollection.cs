namespace MOM.Domain.Common.Relationship.isa95.OperationsSchedule
{
    public class OperationsScheduleHierarchyScopeRelRelationshipCollection : RelationshipCollection<OperationsScheduleHierarchyScopeRelRelationship, Domain.isa95.CommonObjectModels.HierarchyScope>
    {
        public OperationsScheduleHierarchyScopeRelRelationshipCollection(IEnumerable<OperationsScheduleHierarchyScopeRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsScheduleHierarchyScopeRelRelationship>())
        {
        }
    }
}