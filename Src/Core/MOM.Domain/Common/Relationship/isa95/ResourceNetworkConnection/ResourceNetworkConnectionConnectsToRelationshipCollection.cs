namespace MOM.Domain.Common.Relationship.isa95.ResourceNetworkConnection
{
    public class ResourceNetworkConnectionConnectsToRelationshipCollection : RelationshipCollection<ResourceNetworkConnectionConnectsToRelationship, Domain.isa95.CommonObjectModels.Part4.ResourceRelationship.ToResourceReference>
    {
        public ResourceNetworkConnectionConnectsToRelationshipCollection(IEnumerable<ResourceNetworkConnectionConnectsToRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<ResourceNetworkConnectionConnectsToRelationship>())
        {
        }
    }
}