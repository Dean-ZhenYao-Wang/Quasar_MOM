namespace MOM.Domain.Common.Relationship.isa95.OperationsPerformance
{
    public class OperationsPerformanceHierarchyScopeRelRelationshipCollection : RelationshipCollection<OperationsPerformanceHierarchyScopeRelRelationship, Domain.isa95.CommonObjectModels.HierarchyScope>
    {
        public OperationsPerformanceHierarchyScopeRelRelationshipCollection(IEnumerable<OperationsPerformanceHierarchyScopeRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsPerformanceHierarchyScopeRelRelationship>())
        {
        }
    }
}