namespace MOM.Domain.Common.Relationship.isa95.ToResourceReferenceProperty
{
    public class ToResourceReferencePropertyContainsRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.ResourceRelationship.ToResourceReferenceProperty>, IEquatable<ToResourceReferencePropertyContainsRelationship>
    {
        public ToResourceReferencePropertyContainsRelationship()
        {
            Name = "contains";
        }

        public ToResourceReferencePropertyContainsRelationship(Domain.isa95.CommonObjectModels.Part4.ResourceRelationship.ToResourceReferenceProperty source, Domain.isa95.CommonObjectModels.Part4.ResourceRelationship.ToResourceReferenceProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public ToResourceReferencePropertyContainsRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as ToResourceReferencePropertyContainsRelationship);
        }

        public bool Equals(ToResourceReferencePropertyContainsRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(ToResourceReferencePropertyContainsRelationship? left, ToResourceReferencePropertyContainsRelationship? right)
        {
            return EqualityComparer<ToResourceReferencePropertyContainsRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(ToResourceReferencePropertyContainsRelationship? left, ToResourceReferencePropertyContainsRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as ToResourceReferencePropertyContainsRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}