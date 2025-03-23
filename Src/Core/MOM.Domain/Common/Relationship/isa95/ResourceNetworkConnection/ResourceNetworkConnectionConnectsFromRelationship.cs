namespace MOM.Domain.Common.Relationship.isa95.ResourceNetworkConnection
{
    public class ResourceNetworkConnectionConnectsFromRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.ResourceRelationship.FromResourceReference>, IEquatable<ResourceNetworkConnectionConnectsFromRelationship>
    {
        public ResourceNetworkConnectionConnectsFromRelationship()
        {
            Name = "connectsFrom";
        }

        public ResourceNetworkConnectionConnectsFromRelationship(Domain.isa95.CommonObjectModels.Part4.ResourceRelationship.ResourceNetworkConnection source, Domain.isa95.CommonObjectModels.Part4.ResourceRelationship.FromResourceReference target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public ResourceNetworkConnectionConnectsFromRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as ResourceNetworkConnectionConnectsFromRelationship);
        }

        public bool Equals(ResourceNetworkConnectionConnectsFromRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(ResourceNetworkConnectionConnectsFromRelationship? left, ResourceNetworkConnectionConnectsFromRelationship? right)
        {
            return EqualityComparer<ResourceNetworkConnectionConnectsFromRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(ResourceNetworkConnectionConnectsFromRelationship? left, ResourceNetworkConnectionConnectsFromRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as ResourceNetworkConnectionConnectsFromRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}