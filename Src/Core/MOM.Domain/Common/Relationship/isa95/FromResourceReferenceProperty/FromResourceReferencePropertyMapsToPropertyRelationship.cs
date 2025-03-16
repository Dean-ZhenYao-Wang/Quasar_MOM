namespace MOM.Domain.Common.Relationship.isa95.FromResourceReferenceProperty
{
    public class FromResourceReferencePropertyMapsToPropertyRelationship : Relationship<Domain.isa95.CommonObjectModels.ResourceProperty>, IEquatable<FromResourceReferencePropertyMapsToPropertyRelationship>
    {
        public FromResourceReferencePropertyMapsToPropertyRelationship()
        {
            Name = "mapsToProperty";
        }

        public FromResourceReferencePropertyMapsToPropertyRelationship(Domain.isa95.CommonObjectModels.Part4.ResourceRelationship.FromResourceReferenceProperty source, Domain.isa95.CommonObjectModels.ResourceProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public FromResourceReferencePropertyMapsToPropertyRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as FromResourceReferencePropertyMapsToPropertyRelationship);
        }

        public bool Equals(FromResourceReferencePropertyMapsToPropertyRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(FromResourceReferencePropertyMapsToPropertyRelationship? left, FromResourceReferencePropertyMapsToPropertyRelationship? right)
        {
            return EqualityComparer<FromResourceReferencePropertyMapsToPropertyRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(FromResourceReferencePropertyMapsToPropertyRelationship? left, FromResourceReferencePropertyMapsToPropertyRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as FromResourceReferencePropertyMapsToPropertyRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}