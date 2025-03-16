namespace MOM.Domain.Common.Relationship.isa95.ToResourceReferenceProperty
{
    public class ToResourceReferencePropertyContainsRelationshipCollection : RelationshipCollection<ToResourceReferencePropertyContainsRelationship, Domain.isa95.CommonObjectModels.Part4.ResourceRelationship.ToResourceReferenceProperty>
    {
        public ToResourceReferencePropertyContainsRelationshipCollection(IEnumerable<ToResourceReferencePropertyContainsRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<ToResourceReferencePropertyContainsRelationship>())
        {
        }
    }
}