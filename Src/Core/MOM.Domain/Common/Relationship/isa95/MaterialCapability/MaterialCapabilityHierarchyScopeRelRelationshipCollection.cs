namespace MOM.Domain.Common.Relationship.isa95.MaterialCapability
{
    public class MaterialCapabilityHierarchyScopeRelRelationshipCollection : RelationshipCollection<MaterialCapabilityHierarchyScopeRelRelationship, Domain.isa95.CommonObjectModels.HierarchyScope>
    {
        public MaterialCapabilityHierarchyScopeRelRelationshipCollection(IEnumerable<MaterialCapabilityHierarchyScopeRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialCapabilityHierarchyScopeRelRelationship>())
        {
        }
    }
}