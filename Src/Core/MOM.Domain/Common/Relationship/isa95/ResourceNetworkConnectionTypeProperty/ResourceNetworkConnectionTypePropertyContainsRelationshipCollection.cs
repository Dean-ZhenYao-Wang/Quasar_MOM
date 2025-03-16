namespace MOM.Domain.Common.Relationship.isa95.ResourceNetworkConnectionTypeProperty
{
    public class ResourceNetworkConnectionTypePropertyContainsRelationshipCollection : RelationshipCollection<ResourceNetworkConnectionTypePropertyContainsRelationship, Domain.isa95.CommonObjectModels.Part4.ResourceRelationship.ResourceNetworkConnectionTypeProperty>
    {
        public ResourceNetworkConnectionTypePropertyContainsRelationshipCollection(IEnumerable<ResourceNetworkConnectionTypePropertyContainsRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<ResourceNetworkConnectionTypePropertyContainsRelationship>())
        {
        }
    }
}