namespace MOM.Domain.Common.Relationship.isa95.EquipmentSpecificationProperty
{
    public class EquipmentSpecificationPropertyMapsToClassPropertyRelationshipCollection : RelationshipCollection<EquipmentSpecificationPropertyMapsToClassPropertyRelationship, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentClassProperty>
    {
        public EquipmentSpecificationPropertyMapsToClassPropertyRelationshipCollection(IEnumerable<EquipmentSpecificationPropertyMapsToClassPropertyRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<EquipmentSpecificationPropertyMapsToClassPropertyRelationship>())
        {
        }
    }
}