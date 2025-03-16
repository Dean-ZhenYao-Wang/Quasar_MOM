namespace MOM.Domain.Common.Relationship.isa95.OperationsEventClassProperty
{
    public class OperationsEventClassPropertyContainsRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventClassProperty>, IEquatable<OperationsEventClassPropertyContainsRelationship>
    {
        public OperationsEventClassPropertyContainsRelationship()
        {
            Name = "contains";
        }

        public OperationsEventClassPropertyContainsRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventClassProperty source, Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventClassProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationsEventClassPropertyContainsRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsEventClassPropertyContainsRelationship);
        }

        public bool Equals(OperationsEventClassPropertyContainsRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationsEventClassPropertyContainsRelationship? left, OperationsEventClassPropertyContainsRelationship? right)
        {
            return EqualityComparer<OperationsEventClassPropertyContainsRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsEventClassPropertyContainsRelationship? left, OperationsEventClassPropertyContainsRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationsEventClassPropertyContainsRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}