namespace MOM.Domain.Common.Relationship.isa95.FromResourceReferenceProperty
{
    public class FromResourceReferencePropertyMapsToPropertyRelationshipCollection : RelationshipCollection<FromResourceReferencePropertyMapsToPropertyRelationship, Domain.isa95.CommonObjectModels.ResourceProperty>
    {
        public FromResourceReferencePropertyMapsToPropertyRelationshipCollection(IEnumerable<FromResourceReferencePropertyMapsToPropertyRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<FromResourceReferencePropertyMapsToPropertyRelationship>())
        {
        }
    }
}