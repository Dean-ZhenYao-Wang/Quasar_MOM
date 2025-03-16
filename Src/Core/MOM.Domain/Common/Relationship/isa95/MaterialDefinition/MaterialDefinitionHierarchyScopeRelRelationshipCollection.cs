namespace MOM.Domain.Common.Relationship.isa95.MaterialDefinition
{
    public class MaterialDefinitionHierarchyScopeRelRelationshipCollection : RelationshipCollection<MaterialDefinitionHierarchyScopeRelRelationship, Domain.isa95.CommonObjectModels.HierarchyScope>
    {
        public MaterialDefinitionHierarchyScopeRelRelationshipCollection(IEnumerable<MaterialDefinitionHierarchyScopeRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialDefinitionHierarchyScopeRelRelationship>())
        {
        }
    }
}