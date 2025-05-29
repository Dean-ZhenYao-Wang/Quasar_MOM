namespace MOM.Domain.Common.Relationship.isa95.JobList
{
    public class JobListIsMadeUpOfRelationship : Relationship<MOM.Domain.isa95.CommonObjectModels.Part4.WorkSchedule.JobList,Domain.isa95.CommonObjectModels.Part4.WorkSchedule.JobOrder>, IEquatable<JobListIsMadeUpOfRelationship>
    {
        public JobListIsMadeUpOfRelationship()
        {
            Name = "isMadeUpOf";
        }

        public JobListIsMadeUpOfRelationship(MOM.Domain.isa95.CommonObjectModels.Part4.WorkSchedule.JobList source, Domain.isa95.CommonObjectModels.Part4.WorkSchedule.JobOrder target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public JobListIsMadeUpOfRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as JobListIsMadeUpOfRelationship);
        }

        public bool Equals(JobListIsMadeUpOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(JobListIsMadeUpOfRelationship? left, JobListIsMadeUpOfRelationship? right)
        {
            return EqualityComparer<JobListIsMadeUpOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(JobListIsMadeUpOfRelationship? left, JobListIsMadeUpOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as JobListIsMadeUpOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}