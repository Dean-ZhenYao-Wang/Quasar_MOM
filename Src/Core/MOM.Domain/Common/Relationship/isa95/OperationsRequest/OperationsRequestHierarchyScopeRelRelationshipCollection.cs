namespace MOM.Domain.Common.Relationship.isa95.OperationsRequest
{
    public class OperationsRequestHierarchyScopeRelRelationshipCollection : RelationshipCollection<OperationsRequestHierarchyScopeRelRelationship, Domain.isa95.CommonObjectModels.HierarchyScope>
    {
        public OperationsRequestHierarchyScopeRelRelationshipCollection(IEnumerable<OperationsRequestHierarchyScopeRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsRequestHierarchyScopeRelRelationship>())
        {
        }
    }
}