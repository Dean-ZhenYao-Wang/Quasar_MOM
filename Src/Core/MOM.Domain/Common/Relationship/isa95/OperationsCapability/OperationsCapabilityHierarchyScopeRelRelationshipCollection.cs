namespace MOM.Domain.Common.Relationship.isa95.OperationsCapability
{
    public class OperationsCapabilityHierarchyScopeRelRelationshipCollection : RelationshipCollection<OperationsCapabilityHierarchyScopeRelRelationship, Domain.isa95.CommonObjectModels.HierarchyScope>
    {
        public OperationsCapabilityHierarchyScopeRelRelationshipCollection(IEnumerable<OperationsCapabilityHierarchyScopeRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsCapabilityHierarchyScopeRelRelationship>())
        {
        }
    }
}