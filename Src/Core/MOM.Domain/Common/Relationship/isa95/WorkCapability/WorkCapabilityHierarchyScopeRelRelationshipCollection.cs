namespace MOM.Domain.Common.Relationship.isa95.WorkCapability
{
    public class WorkCapabilityHierarchyScopeRelRelationshipCollection : RelationshipCollection<WorkCapabilityHierarchyScopeRelRelationship, Domain.isa95.CommonObjectModels.HierarchyScope>
    {
        public WorkCapabilityHierarchyScopeRelRelationshipCollection(IEnumerable<WorkCapabilityHierarchyScopeRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkCapabilityHierarchyScopeRelRelationship>())
        {
        }
    }
}