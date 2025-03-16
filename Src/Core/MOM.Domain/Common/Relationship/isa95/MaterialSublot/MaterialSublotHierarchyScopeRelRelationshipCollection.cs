namespace MOM.Domain.Common.Relationship.isa95.MaterialSublot
{
    public class MaterialSublotHierarchyScopeRelRelationshipCollection : RelationshipCollection<MaterialSublotHierarchyScopeRelRelationship, Domain.isa95.CommonObjectModels.HierarchyScope>
    {
        public MaterialSublotHierarchyScopeRelRelationshipCollection(IEnumerable<MaterialSublotHierarchyScopeRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialSublotHierarchyScopeRelRelationship>())
        {
        }
    }
}