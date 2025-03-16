namespace MOM.Domain.Common.Relationship.isa95.FromResourceReference
{
    public class FromResourceReferenceHasPropertiesOfRelationshipCollection : RelationshipCollection<FromResourceReferenceHasPropertiesOfRelationship, Domain.isa95.CommonObjectModels.Part4.ResourceRelationship.FromResourceReferenceProperty>
    {
        public FromResourceReferenceHasPropertiesOfRelationshipCollection(IEnumerable<FromResourceReferenceHasPropertiesOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<FromResourceReferenceHasPropertiesOfRelationship>())
        {
        }
    }
}