namespace MOM.Domain.Common.Relationship.isa95.WorkPerformance
{
    public class WorkPerformanceHierarchyScopeRelRelationshipCollection : RelationshipCollection<WorkPerformanceHierarchyScopeRelRelationship, Domain.isa95.CommonObjectModels.HierarchyScope>
    {
        public WorkPerformanceHierarchyScopeRelRelationshipCollection(IEnumerable<WorkPerformanceHierarchyScopeRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkPerformanceHierarchyScopeRelRelationship>())
        {
        }
    }
}