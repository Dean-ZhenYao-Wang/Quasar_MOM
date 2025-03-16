namespace MOM.Domain.Common.Relationship.isa95.Site
{
    public class SiteAreaRelationshipCollection : RelationshipCollection<SiteAreaRelationship, Domain.isa95.EquipmentHierarchy.Area>
    {
        public SiteAreaRelationshipCollection(IEnumerable<SiteAreaRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<SiteAreaRelationship>())
        {
        }
    }
}