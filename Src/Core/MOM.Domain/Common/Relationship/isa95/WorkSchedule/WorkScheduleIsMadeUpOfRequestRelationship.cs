namespace MOM.Domain.Common.Relationship.isa95.WorkSchedule
{
    public class WorkScheduleIsMadeUpOfRequestRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.WorkSchedule.WorkRequest>, IEquatable<WorkScheduleIsMadeUpOfRequestRelationship>
    {
        public WorkScheduleIsMadeUpOfRequestRelationship()
        {
            Name = "isMadeUpOfRequest";
        }

        public WorkScheduleIsMadeUpOfRequestRelationship(Domain.isa95.CommonObjectModels.Part4.WorkSchedule.WorkSchedule source, Domain.isa95.CommonObjectModels.Part4.WorkSchedule.WorkRequest target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkScheduleIsMadeUpOfRequestRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkScheduleIsMadeUpOfRequestRelationship);
        }

        public bool Equals(WorkScheduleIsMadeUpOfRequestRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkScheduleIsMadeUpOfRequestRelationship? left, WorkScheduleIsMadeUpOfRequestRelationship? right)
        {
            return EqualityComparer<WorkScheduleIsMadeUpOfRequestRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkScheduleIsMadeUpOfRequestRelationship? left, WorkScheduleIsMadeUpOfRequestRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkScheduleIsMadeUpOfRequestRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}