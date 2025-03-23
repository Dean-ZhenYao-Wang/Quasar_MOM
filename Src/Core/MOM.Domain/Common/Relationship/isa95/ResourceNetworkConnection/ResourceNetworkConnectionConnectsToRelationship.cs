namespace MOM.Domain.Common.Relationship.isa95.ResourceNetworkConnection
{
    public class ResourceNetworkConnectionConnectsToRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.ResourceRelationship.ToResourceReference>, IEquatable<ResourceNetworkConnectionConnectsToRelationship>
    {
        public ResourceNetworkConnectionConnectsToRelationship()
        {
            Name = "connectsTo";
        }

        public ResourceNetworkConnectionConnectsToRelationship(Domain.isa95.CommonObjectModels.Part4.ResourceRelationship.ResourceNetworkConnection source, Domain.isa95.CommonObjectModels.Part4.ResourceRelationship.ToResourceReference target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public ResourceNetworkConnectionConnectsToRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as ResourceNetworkConnectionConnectsToRelationship);
        }

        public bool Equals(ResourceNetworkConnectionConnectsToRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(ResourceNetworkConnectionConnectsToRelationship? left, ResourceNetworkConnectionConnectsToRelationship? right)
        {
            return EqualityComparer<ResourceNetworkConnectionConnectsToRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(ResourceNetworkConnectionConnectsToRelationship? left, ResourceNetworkConnectionConnectsToRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as ResourceNetworkConnectionConnectsToRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}