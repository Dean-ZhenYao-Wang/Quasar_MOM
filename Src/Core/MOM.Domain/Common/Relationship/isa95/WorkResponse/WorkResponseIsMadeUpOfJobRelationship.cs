namespace MOM.Domain.Common.Relationship.isa95.WorkResponse
{
    public class WorkResponseIsMadeUpOfJobRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.WorkPerformance.JobResponse>, IEquatable<WorkResponseIsMadeUpOfJobRelationship>
    {
        public WorkResponseIsMadeUpOfJobRelationship()
        {
            Name = "isMadeUpOfJob";
        }

        public WorkResponseIsMadeUpOfJobRelationship(Domain.isa95.CommonObjectModels.Part4.WorkPerformance.WorkResponse source, Domain.isa95.CommonObjectModels.Part4.WorkPerformance.JobResponse target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkResponseIsMadeUpOfJobRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkResponseIsMadeUpOfJobRelationship);
        }

        public bool Equals(WorkResponseIsMadeUpOfJobRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkResponseIsMadeUpOfJobRelationship? left, WorkResponseIsMadeUpOfJobRelationship? right)
        {
            return EqualityComparer<WorkResponseIsMadeUpOfJobRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkResponseIsMadeUpOfJobRelationship? left, WorkResponseIsMadeUpOfJobRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkResponseIsMadeUpOfJobRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}