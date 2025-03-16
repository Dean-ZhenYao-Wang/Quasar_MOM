namespace MOM.Domain.Common.Relationship.isa95.OperationsResponse
{
    public class OperationsResponseHierarchyScopeRelRelationshipCollection : RelationshipCollection<OperationsResponseHierarchyScopeRelRelationship, Domain.isa95.CommonObjectModels.HierarchyScope>
    {
        public OperationsResponseHierarchyScopeRelRelationshipCollection(IEnumerable<OperationsResponseHierarchyScopeRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsResponseHierarchyScopeRelRelationship>())
        {
        }
    }
}