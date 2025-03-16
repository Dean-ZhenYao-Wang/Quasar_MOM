namespace MOM.Domain.Common.Relationship.isa95.EquipmentSegmentSpecificationProperty
{
    public class EquipmentSegmentSpecificationPropertyMapsToClassPropertyRelationshipCollection : RelationshipCollection<EquipmentSegmentSpecificationPropertyMapsToClassPropertyRelationship, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentClassProperty>
    {
        public EquipmentSegmentSpecificationPropertyMapsToClassPropertyRelationshipCollection(IEnumerable<EquipmentSegmentSpecificationPropertyMapsToClassPropertyRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<EquipmentSegmentSpecificationPropertyMapsToClassPropertyRelationship>())
        {
        }
    }
}