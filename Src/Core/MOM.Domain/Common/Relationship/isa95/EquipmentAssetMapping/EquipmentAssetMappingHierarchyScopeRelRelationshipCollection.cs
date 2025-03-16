namespace MOM.Domain.Common.Relationship.isa95.EquipmentAssetMapping
{
    public class EquipmentAssetMappingHierarchyScopeRelRelationshipCollection : RelationshipCollection<EquipmentAssetMappingHierarchyScopeRelRelationship, Domain.isa95.CommonObjectModels.HierarchyScope>
    {
        public EquipmentAssetMappingHierarchyScopeRelRelationshipCollection(IEnumerable<EquipmentAssetMappingHierarchyScopeRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<EquipmentAssetMappingHierarchyScopeRelRelationship>())
        {
        }
    }
}