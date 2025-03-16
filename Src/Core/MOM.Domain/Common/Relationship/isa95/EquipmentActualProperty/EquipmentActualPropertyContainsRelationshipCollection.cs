namespace MOM.Domain.Common.Relationship.isa95.EquipmentActualProperty
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class EquipmentActualPropertyContainsRelationshipCollection : RelationshipCollection<EquipmentActualPropertyContainsRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.EquipmentActualProperty>
    {
        public EquipmentActualPropertyContainsRelationshipCollection(IEnumerable<EquipmentActualPropertyContainsRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<EquipmentActualPropertyContainsRelationship>())
        {
        }
    }
}