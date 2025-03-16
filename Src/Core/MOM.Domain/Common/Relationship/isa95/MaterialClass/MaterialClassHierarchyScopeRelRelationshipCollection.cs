namespace MOM.Domain.Common.Relationship.isa95.MaterialClass
{
    public class MaterialClassHierarchyScopeRelRelationshipCollection : RelationshipCollection<MaterialClassHierarchyScopeRelRelationship, Domain.isa95.CommonObjectModels.HierarchyScope>
    {
        public MaterialClassHierarchyScopeRelRelationshipCollection(IEnumerable<MaterialClassHierarchyScopeRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialClassHierarchyScopeRelRelationship>())
        {
        }
    }
}