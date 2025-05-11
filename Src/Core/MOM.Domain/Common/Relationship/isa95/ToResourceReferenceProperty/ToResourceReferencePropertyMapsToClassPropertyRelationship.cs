namespace MOM.Domain.Common.Relationship.isa95.ToResourceReferenceProperty
{
    public class ToResourceReferencePropertyMapsToClassPropertyRelationship : Relationship<Domain.isa95.CommonObjectModels.ResourceClassProperty>, IEquatable<ToResourceReferencePropertyMapsToClassPropertyRelationship>
    {
        public ToResourceReferencePropertyMapsToClassPropertyRelationship()
        {
            Name = "mapsToClassProperty";
        }

        public ToResourceReferencePropertyMapsToClassPropertyRelationship(Domain.isa95.CommonObjectModels.Part4.ResourceRelationship.ToResourceReferenceProperty source, Domain.isa95.CommonObjectModels.ResourceClassProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public ToResourceReferencePropertyMapsToClassPropertyRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as ToResourceReferencePropertyMapsToClassPropertyRelationship);
        }

        public bool Equals(ToResourceReferencePropertyMapsToClassPropertyRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(ToResourceReferencePropertyMapsToClassPropertyRelationship? left, ToResourceReferencePropertyMapsToClassPropertyRelationship? right)
        {
            return EqualityComparer<ToResourceReferencePropertyMapsToClassPropertyRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(ToResourceReferencePropertyMapsToClassPropertyRelationship? left, ToResourceReferencePropertyMapsToClassPropertyRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as ToResourceReferencePropertyMapsToClassPropertyRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}