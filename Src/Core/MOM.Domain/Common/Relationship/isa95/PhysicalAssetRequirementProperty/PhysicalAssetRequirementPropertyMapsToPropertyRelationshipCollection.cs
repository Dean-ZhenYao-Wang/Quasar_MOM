namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetRequirementProperty
{
    public class PhysicalAssetRequirementPropertyMapsToPropertyRelationshipCollection : RelationshipCollection<PhysicalAssetRequirementPropertyMapsToPropertyRelationship, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAssetProperty>
    {
        public PhysicalAssetRequirementPropertyMapsToPropertyRelationshipCollection(IEnumerable<PhysicalAssetRequirementPropertyMapsToPropertyRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PhysicalAssetRequirementPropertyMapsToPropertyRelationship>())
        {
        }
    }
}