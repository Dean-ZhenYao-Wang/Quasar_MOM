namespace MOM.Domain.Common.Relationship.isa95.ResourceNetworkConnectionType
{
    public class ResourceNetworkConnectionTypeHasPropertiesOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.ResourceRelationship.ResourceNetworkConnectionTypeProperty>, IEquatable<ResourceNetworkConnectionTypeHasPropertiesOfRelationship>
    {
        public ResourceNetworkConnectionTypeHasPropertiesOfRelationship()
        {
            Name = "hasPropertiesOf";
        }

        public ResourceNetworkConnectionTypeHasPropertiesOfRelationship(Domain.isa95.CommonObjectModels.Part4.ResourceRelationship.ResourceNetworkConnectionType source, Domain.isa95.CommonObjectModels.Part4.ResourceRelationship.ResourceNetworkConnectionTypeProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public ResourceNetworkConnectionTypeHasPropertiesOfRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as ResourceNetworkConnectionTypeHasPropertiesOfRelationship);
        }

        public bool Equals(ResourceNetworkConnectionTypeHasPropertiesOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(ResourceNetworkConnectionTypeHasPropertiesOfRelationship? left, ResourceNetworkConnectionTypeHasPropertiesOfRelationship? right)
        {
            return EqualityComparer<ResourceNetworkConnectionTypeHasPropertiesOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(ResourceNetworkConnectionTypeHasPropertiesOfRelationship? left, ResourceNetworkConnectionTypeHasPropertiesOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as ResourceNetworkConnectionTypeHasPropertiesOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}