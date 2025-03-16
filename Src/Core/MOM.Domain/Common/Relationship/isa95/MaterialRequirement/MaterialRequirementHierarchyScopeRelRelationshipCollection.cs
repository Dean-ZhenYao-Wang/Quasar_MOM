namespace MOM.Domain.Common.Relationship.isa95.MaterialRequirement
{
    public class MaterialRequirementHierarchyScopeRelRelationshipCollection : RelationshipCollection<MaterialRequirementHierarchyScopeRelRelationship, Domain.isa95.CommonObjectModels.HierarchyScope>
    {
        public MaterialRequirementHierarchyScopeRelRelationshipCollection(IEnumerable<MaterialRequirementHierarchyScopeRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialRequirementHierarchyScopeRelRelationship>())
        {
        }
    }
}