namespace MOM.Domain.Common.Relationship.isa95.ResourceNetworkConnectionProperty
{
    public class ResourceNetworkConnectionPropertyContainsRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.ResourceRelationship.ResourceNetworkConnectionProperty>, IEquatable<ResourceNetworkConnectionPropertyContainsRelationship>
    {
        public ResourceNetworkConnectionPropertyContainsRelationship()
        {
            Name = "contains";
        }

        public ResourceNetworkConnectionPropertyContainsRelationship(Domain.isa95.CommonObjectModels.Part4.ResourceRelationship.ResourceNetworkConnectionProperty source, Domain.isa95.CommonObjectModels.Part4.ResourceRelationship.ResourceNetworkConnectionProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public ResourceNetworkConnectionPropertyContainsRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as ResourceNetworkConnectionPropertyContainsRelationship);
        }

        public bool Equals(ResourceNetworkConnectionPropertyContainsRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(ResourceNetworkConnectionPropertyContainsRelationship? left, ResourceNetworkConnectionPropertyContainsRelationship? right)
        {
            return EqualityComparer<ResourceNetworkConnectionPropertyContainsRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(ResourceNetworkConnectionPropertyContainsRelationship? left, ResourceNetworkConnectionPropertyContainsRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as ResourceNetworkConnectionPropertyContainsRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}