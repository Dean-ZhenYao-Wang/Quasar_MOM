namespace MOM.Domain.Common.Relationship.isa95.ToResourceReferenceProperty
{
    public class ToResourceReferencePropertyMapsToClassPropertyRelationshipCollection : RelationshipCollection<ToResourceReferencePropertyMapsToClassPropertyRelationship, Domain.isa95.CommonObjectModels.ResourceClassProperty>
    {
        public ToResourceReferencePropertyMapsToClassPropertyRelationshipCollection(IEnumerable<ToResourceReferencePropertyMapsToClassPropertyRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<ToResourceReferencePropertyMapsToClassPropertyRelationship>())
        {
        }
    }
}