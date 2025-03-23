namespace MOM.Domain.Common.Relationship.isa95.OperationalLocationClassProperty
{
    public class OperationalLocationClassPropertyContainsRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocationClassProperty>, IEquatable<OperationalLocationClassPropertyContainsRelationship>
    {
        public OperationalLocationClassPropertyContainsRelationship()
        {
            Name = "contains";
        }

        public OperationalLocationClassPropertyContainsRelationship(Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocationClassProperty source, Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocationClassProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationalLocationClassPropertyContainsRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationalLocationClassPropertyContainsRelationship);
        }

        public bool Equals(OperationalLocationClassPropertyContainsRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationalLocationClassPropertyContainsRelationship? left, OperationalLocationClassPropertyContainsRelationship? right)
        {
            return EqualityComparer<OperationalLocationClassPropertyContainsRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationalLocationClassPropertyContainsRelationship? left, OperationalLocationClassPropertyContainsRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationalLocationClassPropertyContainsRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}