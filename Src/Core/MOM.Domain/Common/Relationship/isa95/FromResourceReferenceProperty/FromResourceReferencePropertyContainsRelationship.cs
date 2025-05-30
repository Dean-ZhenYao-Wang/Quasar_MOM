namespace MOM.Domain.Common.Relationship.isa95.FromResourceReferenceProperty
{
    public class FromResourceReferencePropertyContainsRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.ResourceRelationship.FromResourceReferenceProperty ,Domain.isa95.CommonObjectModels.Part4.ResourceRelationship.FromResourceReferenceProperty>, IEquatable<FromResourceReferencePropertyContainsRelationship>
    {
        public FromResourceReferencePropertyContainsRelationship()
        {
            Name = "contains";
        }

        public FromResourceReferencePropertyContainsRelationship(Domain.isa95.CommonObjectModels.Part4.ResourceRelationship.FromResourceReferenceProperty source, Domain.isa95.CommonObjectModels.Part4.ResourceRelationship.FromResourceReferenceProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public FromResourceReferencePropertyContainsRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as FromResourceReferencePropertyContainsRelationship);
        }

        public bool Equals(FromResourceReferencePropertyContainsRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(FromResourceReferencePropertyContainsRelationship? left, FromResourceReferencePropertyContainsRelationship? right)
        {
            return EqualityComparer<FromResourceReferencePropertyContainsRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(FromResourceReferencePropertyContainsRelationship? left, FromResourceReferencePropertyContainsRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as FromResourceReferencePropertyContainsRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}