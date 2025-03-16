namespace MOM.Domain.Common.Relationship.isa95.EquipmentActualProperty
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class EquipmentActualPropertyMapsToPropertyRelationshipCollection : RelationshipCollection<EquipmentActualPropertyMapsToPropertyRelationship, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentProperty>
    {
        public EquipmentActualPropertyMapsToPropertyRelationshipCollection(IEnumerable<EquipmentActualPropertyMapsToPropertyRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<EquipmentActualPropertyMapsToPropertyRelationship>())
        {
        }
    }
}