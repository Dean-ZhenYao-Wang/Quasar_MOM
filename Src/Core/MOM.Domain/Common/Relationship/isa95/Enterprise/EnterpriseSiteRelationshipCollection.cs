namespace MOM.Domain.Common.Relationship.isa95.Enterprise
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class EnterpriseSiteRelationshipCollection : RelationshipCollection<EnterpriseSiteRelationship, Domain.isa95.EquipmentHierarchy.Site>
    {
        public EnterpriseSiteRelationshipCollection(IEnumerable<EnterpriseSiteRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<EnterpriseSiteRelationship>())
        {
        }
    }
}