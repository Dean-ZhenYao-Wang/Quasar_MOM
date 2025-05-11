namespace MOM.Domain.Common.Relationship.isa95.OperationsPerformance
{
    public class OperationsPerformanceIsMadeUpOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.OperationsResponse>, IEquatable<OperationsPerformanceIsMadeUpOfRelationship>
    {
        public OperationsPerformanceIsMadeUpOfRelationship()
        {
            Name = "isMadeUpOf";
        }

        public OperationsPerformanceIsMadeUpOfRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.OperationsPerformance source, Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.OperationsResponse target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationsPerformanceIsMadeUpOfRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsPerformanceIsMadeUpOfRelationship);
        }

        public bool Equals(OperationsPerformanceIsMadeUpOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationsPerformanceIsMadeUpOfRelationship? left, OperationsPerformanceIsMadeUpOfRelationship? right)
        {
            return EqualityComparer<OperationsPerformanceIsMadeUpOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsPerformanceIsMadeUpOfRelationship? left, OperationsPerformanceIsMadeUpOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationsPerformanceIsMadeUpOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}