namespace MOM.Domain.Common.Relationship.isa95.MaterialLot
{
    public class MaterialLotHierarchyScopeRelRelationshipCollection : RelationshipCollection<MaterialLotHierarchyScopeRelRelationship, Domain.isa95.CommonObjectModels.HierarchyScope>
    {
        public MaterialLotHierarchyScopeRelRelationshipCollection(IEnumerable<MaterialLotHierarchyScopeRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialLotHierarchyScopeRelRelationship>())
        {
        }
    }
}