namespace MOM.Domain.Common.Relationship.isa95.OperationsEventProperty
{
    public class OperationsEventPropertyContainsRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventProperty>, IEquatable<OperationsEventPropertyContainsRelationship>
    {
        public OperationsEventPropertyContainsRelationship()
        {
            Name = "contains";
        }

        public OperationsEventPropertyContainsRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventProperty source, Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationsEventPropertyContainsRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsEventPropertyContainsRelationship);
        }

        public bool Equals(OperationsEventPropertyContainsRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationsEventPropertyContainsRelationship? left, OperationsEventPropertyContainsRelationship? right)
        {
            return EqualityComparer<OperationsEventPropertyContainsRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsEventPropertyContainsRelationship? left, OperationsEventPropertyContainsRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationsEventPropertyContainsRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}