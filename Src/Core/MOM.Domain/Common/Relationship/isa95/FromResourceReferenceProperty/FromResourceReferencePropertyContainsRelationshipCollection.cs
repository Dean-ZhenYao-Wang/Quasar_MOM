namespace MOM.Domain.Common.Relationship.isa95.FromResourceReferenceProperty
{
    public class FromResourceReferencePropertyContainsRelationshipCollection : RelationshipCollection<FromResourceReferencePropertyContainsRelationship, Domain.isa95.CommonObjectModels.Part4.ResourceRelationship.FromResourceReferenceProperty>
    {
        public FromResourceReferencePropertyContainsRelationshipCollection(IEnumerable<FromResourceReferencePropertyContainsRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<FromResourceReferencePropertyContainsRelationship>())
        {
        }
    }
}