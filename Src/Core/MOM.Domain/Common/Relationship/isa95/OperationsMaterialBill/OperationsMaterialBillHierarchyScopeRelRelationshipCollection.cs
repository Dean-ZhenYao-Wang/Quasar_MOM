namespace MOM.Domain.Common.Relationship.isa95.OperationsMaterialBill
{
    public class OperationsMaterialBillHierarchyScopeRelRelationshipCollection : RelationshipCollection<OperationsMaterialBillHierarchyScopeRelRelationship, Domain.isa95.CommonObjectModels.HierarchyScope>
    {
        public OperationsMaterialBillHierarchyScopeRelRelationshipCollection(IEnumerable<OperationsMaterialBillHierarchyScopeRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsMaterialBillHierarchyScopeRelRelationship>())
        {
        }
    }
}