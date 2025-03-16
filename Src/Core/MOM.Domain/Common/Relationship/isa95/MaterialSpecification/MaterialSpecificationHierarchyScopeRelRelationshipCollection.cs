namespace MOM.Domain.Common.Relationship.isa95.MaterialSpecification
{
    public class MaterialSpecificationHierarchyScopeRelRelationshipCollection : RelationshipCollection<MaterialSpecificationHierarchyScopeRelRelationship, Domain.isa95.CommonObjectModels.HierarchyScope>
    {
        public MaterialSpecificationHierarchyScopeRelRelationshipCollection(IEnumerable<MaterialSpecificationHierarchyScopeRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialSpecificationHierarchyScopeRelRelationship>())
        {
        }
    }
}