namespace MOM.Domain.Common.Relationship.isa95.ResourceNetworkConnectionType
{
    public class ResourceNetworkConnectionTypeHasPropertiesOfRelationshipCollection : RelationshipCollection<ResourceNetworkConnectionTypeHasPropertiesOfRelationship, Domain.isa95.CommonObjectModels.Part4.ResourceRelationship.ResourceNetworkConnectionTypeProperty>
    {
        public ResourceNetworkConnectionTypeHasPropertiesOfRelationshipCollection(IEnumerable<ResourceNetworkConnectionTypeHasPropertiesOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<ResourceNetworkConnectionTypeHasPropertiesOfRelationship>())
        {
        }
    }
}