namespace MOM.Domain.Common.Relationship.isa95.WorkPerformance
{
    public class WorkPerformanceCorrespondsToRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.WorkSchedule.WorkSchedule>, IEquatable<WorkPerformanceCorrespondsToRelationship>
    {
        public WorkPerformanceCorrespondsToRelationship()
        {
            Name = "correspondsTo";
        }

        public WorkPerformanceCorrespondsToRelationship(Domain.isa95.CommonObjectModels.Part4.WorkPerformance.WorkPerformance source, Domain.isa95.CommonObjectModels.Part4.WorkSchedule.WorkSchedule target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkPerformanceCorrespondsToRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkPerformanceCorrespondsToRelationship);
        }

        public bool Equals(WorkPerformanceCorrespondsToRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkPerformanceCorrespondsToRelationship? left, WorkPerformanceCorrespondsToRelationship? right)
        {
            return EqualityComparer<WorkPerformanceCorrespondsToRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkPerformanceCorrespondsToRelationship? left, WorkPerformanceCorrespondsToRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkPerformanceCorrespondsToRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}