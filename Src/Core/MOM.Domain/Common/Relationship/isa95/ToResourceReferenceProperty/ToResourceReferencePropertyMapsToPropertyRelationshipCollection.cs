namespace MOM.Domain.Common.Relationship.isa95.ToResourceReferenceProperty
{
    public class ToResourceReferencePropertyMapsToPropertyRelationshipCollection : RelationshipCollection<ToResourceReferencePropertyMapsToPropertyRelationship, Domain.isa95.CommonObjectModels.ResourceProperty>
    {
        public ToResourceReferencePropertyMapsToPropertyRelationshipCollection(IEnumerable<ToResourceReferencePropertyMapsToPropertyRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<ToResourceReferencePropertyMapsToPropertyRelationship>())
        {
        }
    }
}