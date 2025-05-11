namespace MOM.Domain.Common.Relationship.isa95.OperationsPerformance
{
    public class OperationsPerformanceReferencesRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.OperationsSchedule>, IEquatable<OperationsPerformanceReferencesRelationship>
    {
        public OperationsPerformanceReferencesRelationship()
        {
            Name = "references";
        }

        public OperationsPerformanceReferencesRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.OperationsPerformance source, Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.OperationsSchedule target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationsPerformanceReferencesRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsPerformanceReferencesRelationship);
        }

        public bool Equals(OperationsPerformanceReferencesRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationsPerformanceReferencesRelationship? left, OperationsPerformanceReferencesRelationship? right)
        {
            return EqualityComparer<OperationsPerformanceReferencesRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsPerformanceReferencesRelationship? left, OperationsPerformanceReferencesRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationsPerformanceReferencesRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}