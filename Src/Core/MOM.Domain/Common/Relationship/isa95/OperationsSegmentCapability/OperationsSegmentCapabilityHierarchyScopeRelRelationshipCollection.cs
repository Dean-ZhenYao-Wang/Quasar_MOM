namespace MOM.Domain.Common.Relationship.isa95.OperationsSegmentCapability
{
    public class OperationsSegmentCapabilityHierarchyScopeRelRelationshipCollection : RelationshipCollection<OperationsSegmentCapabilityHierarchyScopeRelRelationship, Domain.isa95.CommonObjectModels.HierarchyScope>
    {
        public OperationsSegmentCapabilityHierarchyScopeRelRelationshipCollection(IEnumerable<OperationsSegmentCapabilityHierarchyScopeRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsSegmentCapabilityHierarchyScopeRelRelationship>())
        {
        }
    }
}