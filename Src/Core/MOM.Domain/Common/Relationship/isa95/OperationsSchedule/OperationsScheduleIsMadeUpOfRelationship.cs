namespace MOM.Domain.Common.Relationship.isa95.OperationsSchedule
{
    public class OperationsScheduleIsMadeUpOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.OperationsRequest>, IEquatable<OperationsScheduleIsMadeUpOfRelationship>
    {
        public OperationsScheduleIsMadeUpOfRelationship()
        {
            Name = "isMadeUpOf";
        }

        public OperationsScheduleIsMadeUpOfRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.OperationsSchedule source, Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.OperationsRequest target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationsScheduleIsMadeUpOfRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsScheduleIsMadeUpOfRelationship);
        }

        public bool Equals(OperationsScheduleIsMadeUpOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationsScheduleIsMadeUpOfRelationship? left, OperationsScheduleIsMadeUpOfRelationship? right)
        {
            return EqualityComparer<OperationsScheduleIsMadeUpOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsScheduleIsMadeUpOfRelationship? left, OperationsScheduleIsMadeUpOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationsScheduleIsMadeUpOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}