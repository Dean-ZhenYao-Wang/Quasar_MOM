namespace MOM.Domain.Common.Relationship.isa95.MaterialSegmentSpecification
{
    public class MaterialSegmentSpecificationHierarchyScopeRelRelationshipCollection : RelationshipCollection<MaterialSegmentSpecificationHierarchyScopeRelRelationship, Domain.isa95.CommonObjectModels.HierarchyScope>
    {
        public MaterialSegmentSpecificationHierarchyScopeRelRelationshipCollection(IEnumerable<MaterialSegmentSpecificationHierarchyScopeRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialSegmentSpecificationHierarchyScopeRelRelationship>())
        {
        }
    }
}