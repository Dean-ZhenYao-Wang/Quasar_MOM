namespace MOM.Domain.Common.Relationship.isa95.OperationalLocationProperty
{
    public class OperationalLocationPropertyContainsRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocationProperty>, IEquatable<OperationalLocationPropertyContainsRelationship>
    {
        public OperationalLocationPropertyContainsRelationship()
        {
            Name = "contains";
        }

        public OperationalLocationPropertyContainsRelationship(Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocationProperty source, Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocationProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationalLocationPropertyContainsRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationalLocationPropertyContainsRelationship);
        }

        public bool Equals(OperationalLocationPropertyContainsRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationalLocationPropertyContainsRelationship? left, OperationalLocationPropertyContainsRelationship? right)
        {
            return EqualityComparer<OperationalLocationPropertyContainsRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationalLocationPropertyContainsRelationship? left, OperationalLocationPropertyContainsRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationalLocationPropertyContainsRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}