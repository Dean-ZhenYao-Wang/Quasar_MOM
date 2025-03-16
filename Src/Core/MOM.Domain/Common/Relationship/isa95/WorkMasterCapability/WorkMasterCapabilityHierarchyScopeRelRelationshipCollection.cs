namespace MOM.Domain.Common.Relationship.isa95.WorkMasterCapability
{
    public class WorkMasterCapabilityHierarchyScopeRelRelationshipCollection : RelationshipCollection<WorkMasterCapabilityHierarchyScopeRelRelationship, Domain.isa95.CommonObjectModels.HierarchyScope>
    {
        public WorkMasterCapabilityHierarchyScopeRelRelationshipCollection(IEnumerable<WorkMasterCapabilityHierarchyScopeRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkMasterCapabilityHierarchyScopeRelRelationship>())
        {
        }
    }
}