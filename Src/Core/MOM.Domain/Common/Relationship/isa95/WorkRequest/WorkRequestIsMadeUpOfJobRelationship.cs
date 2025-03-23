namespace MOM.Domain.Common.Relationship.isa95.WorkRequest
{
    public class WorkRequestIsMadeUpOfJobRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.WorkSchedule.JobOrder>, IEquatable<WorkRequestIsMadeUpOfJobRelationship>
    {
        public WorkRequestIsMadeUpOfJobRelationship()
        {
            Name = "isMadeUpOfJob";
        }

        public WorkRequestIsMadeUpOfJobRelationship(Domain.isa95.CommonObjectModels.Part4.WorkSchedule.WorkRequest source, Domain.isa95.CommonObjectModels.Part4.WorkSchedule.JobOrder target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkRequestIsMadeUpOfJobRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkRequestIsMadeUpOfJobRelationship);
        }

        public bool Equals(WorkRequestIsMadeUpOfJobRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkRequestIsMadeUpOfJobRelationship? left, WorkRequestIsMadeUpOfJobRelationship? right)
        {
            return EqualityComparer<WorkRequestIsMadeUpOfJobRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkRequestIsMadeUpOfJobRelationship? left, WorkRequestIsMadeUpOfJobRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkRequestIsMadeUpOfJobRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}