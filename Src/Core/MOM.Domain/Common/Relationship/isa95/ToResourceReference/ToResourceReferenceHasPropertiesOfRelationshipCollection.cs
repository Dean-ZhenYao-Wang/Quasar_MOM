namespace MOM.Domain.Common.Relationship.isa95.ToResourceReference
{
    public class ToResourceReferenceHasPropertiesOfRelationshipCollection : RelationshipCollection<ToResourceReferenceHasPropertiesOfRelationship, Domain.isa95.CommonObjectModels.Part4.ResourceRelationship.ToResourceReferenceProperty>
    {
        public ToResourceReferenceHasPropertiesOfRelationshipCollection(IEnumerable<ToResourceReferenceHasPropertiesOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<ToResourceReferenceHasPropertiesOfRelationship>())
        {
        }
    }
}