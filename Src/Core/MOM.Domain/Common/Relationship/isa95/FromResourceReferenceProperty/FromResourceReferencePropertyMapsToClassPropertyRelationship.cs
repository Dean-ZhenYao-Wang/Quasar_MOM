namespace MOM.Domain.Common.Relationship.isa95.FromResourceReferenceProperty
{
    public class FromResourceReferencePropertyMapsToClassPropertyRelationship : Relationship<Domain.isa95.CommonObjectModels.ResourceClassProperty>, IEquatable<FromResourceReferencePropertyMapsToClassPropertyRelationship>
    {
        public FromResourceReferencePropertyMapsToClassPropertyRelationship()
        {
            Name = "mapsToClassProperty";
        }

        public FromResourceReferencePropertyMapsToClassPropertyRelationship(Domain.isa95.CommonObjectModels.Part4.ResourceRelationship.FromResourceReferenceProperty source, Domain.isa95.CommonObjectModels.ResourceClassProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public FromResourceReferencePropertyMapsToClassPropertyRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as FromResourceReferencePropertyMapsToClassPropertyRelationship);
        }

        public bool Equals(FromResourceReferencePropertyMapsToClassPropertyRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(FromResourceReferencePropertyMapsToClassPropertyRelationship? left, FromResourceReferencePropertyMapsToClassPropertyRelationship? right)
        {
            return EqualityComparer<FromResourceReferencePropertyMapsToClassPropertyRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(FromResourceReferencePropertyMapsToClassPropertyRelationship? left, FromResourceReferencePropertyMapsToClassPropertyRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as FromResourceReferencePropertyMapsToClassPropertyRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}