namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetRequirementProperty
{
    public class PhysicalAssetRequirementPropertyMapsToClassPropertyRelationshipCollection : RelationshipCollection<PhysicalAssetRequirementPropertyMapsToClassPropertyRelationship, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAssetClassProperty>
    {
        public PhysicalAssetRequirementPropertyMapsToClassPropertyRelationshipCollection(IEnumerable<PhysicalAssetRequirementPropertyMapsToClassPropertyRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PhysicalAssetRequirementPropertyMapsToClassPropertyRelationship>())
        {
        }
    }
}