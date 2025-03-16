namespace MOM.Domain.Common.Relationship.isa95.OperationsEvent
{
    public class OperationsEventHierarchyScopeRelRelationshipCollection : RelationshipCollection<OperationsEventHierarchyScopeRelRelationship, Domain.isa95.CommonObjectModels.HierarchyScope>
    {
        public OperationsEventHierarchyScopeRelRelationshipCollection(IEnumerable<OperationsEventHierarchyScopeRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsEventHierarchyScopeRelRelationship>())
        {
        }
    }
}