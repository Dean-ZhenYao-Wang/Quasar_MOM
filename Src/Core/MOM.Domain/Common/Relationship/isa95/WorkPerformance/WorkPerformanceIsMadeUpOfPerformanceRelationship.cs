namespace MOM.Domain.Common.Relationship.isa95.WorkPerformance
{
    public class WorkPerformanceIsMadeUpOfPerformanceRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.WorkPerformance.WorkPerformance>, IEquatable<WorkPerformanceIsMadeUpOfPerformanceRelationship>
    {
        public WorkPerformanceIsMadeUpOfPerformanceRelationship()
        {
            Name = "isMadeUpOfPerformance";
        }

        public WorkPerformanceIsMadeUpOfPerformanceRelationship(Domain.isa95.CommonObjectModels.Part4.WorkPerformance.WorkPerformance source, Domain.isa95.CommonObjectModels.Part4.WorkPerformance.WorkPerformance target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkPerformanceIsMadeUpOfPerformanceRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkPerformanceIsMadeUpOfPerformanceRelationship);
        }

        public bool Equals(WorkPerformanceIsMadeUpOfPerformanceRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkPerformanceIsMadeUpOfPerformanceRelationship? left, WorkPerformanceIsMadeUpOfPerformanceRelationship? right)
        {
            return EqualityComparer<WorkPerformanceIsMadeUpOfPerformanceRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkPerformanceIsMadeUpOfPerformanceRelationship? left, WorkPerformanceIsMadeUpOfPerformanceRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkPerformanceIsMadeUpOfPerformanceRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}