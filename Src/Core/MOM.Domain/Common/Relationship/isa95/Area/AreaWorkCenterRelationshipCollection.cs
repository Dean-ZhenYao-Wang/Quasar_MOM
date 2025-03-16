using System.Collections.Generic;
using System.Linq;

namespace MOM.Domain.Common.Relationship.isa95.Area
{
    public class AreaWorkCenterRelationshipCollection : RelationshipCollection<AreaWorkCenterRelationship, Domain.isa95.EquipmentHierarchy.WorkCenter>
    {
        public AreaWorkCenterRelationshipCollection(IEnumerable<AreaWorkCenterRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<AreaWorkCenterRelationship>())
        {
        }
    }
}