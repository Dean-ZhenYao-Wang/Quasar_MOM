namespace MOM.Domain.Common.Relationship.isa95.ProcessSegmentCapability
{
    public class ProcessSegmentCapabilityHierarchyScopeRelRelationshipCollection : RelationshipCollection<ProcessSegmentCapabilityHierarchyScopeRelRelationship, Domain.isa95.CommonObjectModels.HierarchyScope>
    {
        public ProcessSegmentCapabilityHierarchyScopeRelRelationshipCollection(IEnumerable<ProcessSegmentCapabilityHierarchyScopeRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<ProcessSegmentCapabilityHierarchyScopeRelRelationship>())
        {
        }
    }
}