namespace MOM.Domain.Common.Relationship.isa95.JobResponseList
{
    public class JobResponseListIsMadeUpOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.WorkPerformance.JobResponseList,Domain.isa95.CommonObjectModels.Part4.WorkPerformance.JobResponse>, IEquatable<JobResponseListIsMadeUpOfRelationship>
    {
        public JobResponseListIsMadeUpOfRelationship()
        {
            Name = "isMadeUpOf";
        }

        public JobResponseListIsMadeUpOfRelationship(Domain.isa95.CommonObjectModels.Part4.WorkPerformance.JobResponseList source, Domain.isa95.CommonObjectModels.Part4.WorkPerformance.JobResponse target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public JobResponseListIsMadeUpOfRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as JobResponseListIsMadeUpOfRelationship);
        }

        public bool Equals(JobResponseListIsMadeUpOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(JobResponseListIsMadeUpOfRelationship? left, JobResponseListIsMadeUpOfRelationship? right)
        {
            return EqualityComparer<JobResponseListIsMadeUpOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(JobResponseListIsMadeUpOfRelationship? left, JobResponseListIsMadeUpOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as JobResponseListIsMadeUpOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}