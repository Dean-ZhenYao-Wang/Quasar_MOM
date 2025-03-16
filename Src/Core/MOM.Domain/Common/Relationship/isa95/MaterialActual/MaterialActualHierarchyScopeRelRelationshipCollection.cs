namespace MOM.Domain.Common.Relationship.isa95.MaterialActual
{
    public class MaterialActualHierarchyScopeRelRelationshipCollection : RelationshipCollection<MaterialActualHierarchyScopeRelRelationship, Domain.isa95.CommonObjectModels.HierarchyScope>
    {
        public MaterialActualHierarchyScopeRelRelationshipCollection(IEnumerable<MaterialActualHierarchyScopeRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialActualHierarchyScopeRelRelationship>())
        {
        }
    }
}