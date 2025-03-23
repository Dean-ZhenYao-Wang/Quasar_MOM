namespace MOM.Domain.Common.Relationship.isa95.WorkSchedule
{
    public class WorkScheduleIsMadeUpOfScheduleRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.WorkSchedule.WorkSchedule>, IEquatable<WorkScheduleIsMadeUpOfScheduleRelationship>
    {
        public WorkScheduleIsMadeUpOfScheduleRelationship()
        {
            Name = "isMadeUpOfSchedule";
        }

        public WorkScheduleIsMadeUpOfScheduleRelationship(Domain.isa95.CommonObjectModels.Part4.WorkSchedule.WorkSchedule source, Domain.isa95.CommonObjectModels.Part4.WorkSchedule.WorkSchedule target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkScheduleIsMadeUpOfScheduleRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkScheduleIsMadeUpOfScheduleRelationship);
        }

        public bool Equals(WorkScheduleIsMadeUpOfScheduleRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkScheduleIsMadeUpOfScheduleRelationship? left, WorkScheduleIsMadeUpOfScheduleRelationship? right)
        {
            return EqualityComparer<WorkScheduleIsMadeUpOfScheduleRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkScheduleIsMadeUpOfScheduleRelationship? left, WorkScheduleIsMadeUpOfScheduleRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkScheduleIsMadeUpOfScheduleRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}