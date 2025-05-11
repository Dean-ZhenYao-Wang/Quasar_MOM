namespace MOM.Domain.Common.Relationship.isa95.ResourceRelationshipNetworkProperty
{
    public class ResourceRelationshipNetworkPropertyContainsRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.ResourceRelationship.ResourceRelationshipNetworkProperty>, IEquatable<ResourceRelationshipNetworkPropertyContainsRelationship>
    {
        public ResourceRelationshipNetworkPropertyContainsRelationship()
        {
            Name = "contains";
        }

        public ResourceRelationshipNetworkPropertyContainsRelationship(Domain.isa95.CommonObjectModels.Part4.ResourceRelationship.ResourceRelationshipNetworkProperty source, Domain.isa95.CommonObjectModels.Part4.ResourceRelationship.ResourceRelationshipNetworkProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public ResourceRelationshipNetworkPropertyContainsRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as ResourceRelationshipNetworkPropertyContainsRelationship);
        }

        public bool Equals(ResourceRelationshipNetworkPropertyContainsRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(ResourceRelationshipNetworkPropertyContainsRelationship? left, ResourceRelationshipNetworkPropertyContainsRelationship? right)
        {
            return EqualityComparer<ResourceRelationshipNetworkPropertyContainsRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(ResourceRelationshipNetworkPropertyContainsRelationship? left, ResourceRelationshipNetworkPropertyContainsRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as ResourceRelationshipNetworkPropertyContainsRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}