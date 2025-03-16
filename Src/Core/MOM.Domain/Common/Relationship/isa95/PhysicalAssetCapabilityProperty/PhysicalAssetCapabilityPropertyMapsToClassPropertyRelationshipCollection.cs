namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetCapabilityProperty
{
    public class PhysicalAssetCapabilityPropertyMapsToClassPropertyRelationshipCollection : RelationshipCollection<PhysicalAssetCapabilityPropertyMapsToClassPropertyRelationship, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAssetClassProperty>
    {
        public PhysicalAssetCapabilityPropertyMapsToClassPropertyRelationshipCollection(IEnumerable<PhysicalAssetCapabilityPropertyMapsToClassPropertyRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PhysicalAssetCapabilityPropertyMapsToClassPropertyRelationship>())
        {
        }
    }
}