namespace MOM.Domain.Common.Relationship.isa95.ToResourceReferenceProperty
{
    public class ToResourceReferencePropertyMapsToPropertyRelationship : Relationship<Domain.isa95.CommonObjectModels.ResourceProperty>, IEquatable<ToResourceReferencePropertyMapsToPropertyRelationship>
    {
        public ToResourceReferencePropertyMapsToPropertyRelationship()
        {
            Name = "mapsToProperty";
        }

        public ToResourceReferencePropertyMapsToPropertyRelationship(Domain.isa95.CommonObjectModels.Part4.ResourceRelationship.ToResourceReferenceProperty source, Domain.isa95.CommonObjectModels.ResourceProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public ToResourceReferencePropertyMapsToPropertyRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as ToResourceReferencePropertyMapsToPropertyRelationship);
        }

        public bool Equals(ToResourceReferencePropertyMapsToPropertyRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(ToResourceReferencePropertyMapsToPropertyRelationship? left, ToResourceReferencePropertyMapsToPropertyRelationship? right)
        {
            return EqualityComparer<ToResourceReferencePropertyMapsToPropertyRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(ToResourceReferencePropertyMapsToPropertyRelationship? left, ToResourceReferencePropertyMapsToPropertyRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as ToResourceReferencePropertyMapsToPropertyRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}