namespace MOM.Domain.Common.Relationship.isa95.ResourceRelationshipNetwork
{
    public class ResourceRelationshipNetworkIsACollectionOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.ResourceRelationship.ResourceNetworkConnection>, IEquatable<ResourceRelationshipNetworkIsACollectionOfRelationship>
    {
        public ResourceRelationshipNetworkIsACollectionOfRelationship()
        {
            Name = "isACollectionOf";
        }

        public ResourceRelationshipNetworkIsACollectionOfRelationship(Domain.isa95.CommonObjectModels.Part4.ResourceRelationship.ResourceRelationshipNetwork source, Domain.isa95.CommonObjectModels.Part4.ResourceRelationship.ResourceNetworkConnection target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public ResourceRelationshipNetworkIsACollectionOfRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as ResourceRelationshipNetworkIsACollectionOfRelationship);
        }

        public bool Equals(ResourceRelationshipNetworkIsACollectionOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(ResourceRelationshipNetworkIsACollectionOfRelationship? left, ResourceRelationshipNetworkIsACollectionOfRelationship? right)
        {
            return EqualityComparer<ResourceRelationshipNetworkIsACollectionOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(ResourceRelationshipNetworkIsACollectionOfRelationship? left, ResourceRelationshipNetworkIsACollectionOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as ResourceRelationshipNetworkIsACollectionOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}