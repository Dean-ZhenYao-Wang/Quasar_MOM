namespace MOM.Domain.Common.Relationship.isa95.EquipmentActualProperty
{
    using System.Collections.Generic;
    using System.Linq;

    public class EquipmentActualPropertyMapsToClassPropertyRelationshipCollection : RelationshipCollection<EquipmentActualPropertyMapsToClassPropertyRelationship, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentClassProperty>
    {
        public EquipmentActualPropertyMapsToClassPropertyRelationshipCollection(IEnumerable<EquipmentActualPropertyMapsToClassPropertyRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<EquipmentActualPropertyMapsToClassPropertyRelationship>())
        {
        }
    }
}