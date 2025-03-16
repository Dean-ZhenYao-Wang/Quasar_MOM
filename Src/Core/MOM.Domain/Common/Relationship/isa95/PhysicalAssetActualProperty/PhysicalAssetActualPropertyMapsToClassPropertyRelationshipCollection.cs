namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetActualProperty
{
    public class PhysicalAssetActualPropertyMapsToClassPropertyRelationshipCollection : RelationshipCollection<PhysicalAssetActualPropertyMapsToClassPropertyRelationship, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAssetClassProperty>
    {
        public PhysicalAssetActualPropertyMapsToClassPropertyRelationshipCollection(IEnumerable<PhysicalAssetActualPropertyMapsToClassPropertyRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PhysicalAssetActualPropertyMapsToClassPropertyRelationship>())
        {
        }
    }
}