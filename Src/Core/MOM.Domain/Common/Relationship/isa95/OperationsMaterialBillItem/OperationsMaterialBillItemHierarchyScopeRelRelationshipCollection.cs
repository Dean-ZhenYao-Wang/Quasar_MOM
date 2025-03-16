namespace MOM.Domain.Common.Relationship.isa95.OperationsMaterialBillItem
{
    public class OperationsMaterialBillItemHierarchyScopeRelRelationshipCollection : RelationshipCollection<OperationsMaterialBillItemHierarchyScopeRelRelationship, Domain.isa95.CommonObjectModels.HierarchyScope>
    {
        public OperationsMaterialBillItemHierarchyScopeRelRelationshipCollection(IEnumerable<OperationsMaterialBillItemHierarchyScopeRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsMaterialBillItemHierarchyScopeRelRelationship>())
        {
        }
    }
}