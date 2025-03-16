namespace MOM.Domain.Common.Relationship.isa95.FromResourceReferenceProperty
{
    public class FromResourceReferencePropertyMapsToClassPropertyRelationshipCollection : RelationshipCollection<FromResourceReferencePropertyMapsToClassPropertyRelationship, Domain.isa95.CommonObjectModels.ResourceClassProperty>
    {
        public FromResourceReferencePropertyMapsToClassPropertyRelationshipCollection(IEnumerable<FromResourceReferencePropertyMapsToClassPropertyRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<FromResourceReferencePropertyMapsToClassPropertyRelationship>())
        {
        }
    }
}