namespace MOM.Domain.Common.Relationship.isa95.ResourceNetworkConnectionProperty
{
    public class ResourceNetworkConnectionPropertyContainsRelationshipCollection : RelationshipCollection<ResourceNetworkConnectionPropertyContainsRelationship, Domain.isa95.CommonObjectModels.Part4.ResourceRelationship.ResourceNetworkConnectionProperty>
    {
        public ResourceNetworkConnectionPropertyContainsRelationshipCollection(IEnumerable<ResourceNetworkConnectionPropertyContainsRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<ResourceNetworkConnectionPropertyContainsRelationship>())
        {
        }
    }
}