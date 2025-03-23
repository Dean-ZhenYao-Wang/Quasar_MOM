namespace MOM.Domain.Common.Relationship.isa95.JobResponse
{
    public class JobResponseCorrespondsToJobOrderRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.WorkSchedule.JobOrder>, IEquatable<JobResponseCorrespondsToJobOrderRelationship>
    {
        public JobResponseCorrespondsToJobOrderRelationship()
        {
            Name = "correspondsToJobOrder";
        }

        public JobResponseCorrespondsToJobOrderRelationship(Domain.isa95.CommonObjectModels.Part4.WorkPerformance.JobResponse source, Domain.isa95.CommonObjectModels.Part4.WorkSchedule.JobOrder target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public JobResponseCorrespondsToJobOrderRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as JobResponseCorrespondsToJobOrderRelationship);
        }

        public bool Equals(JobResponseCorrespondsToJobOrderRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(JobResponseCorrespondsToJobOrderRelationship? left, JobResponseCorrespondsToJobOrderRelationship? right)
        {
            return EqualityComparer<JobResponseCorrespondsToJobOrderRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(JobResponseCorrespondsToJobOrderRelationship? left, JobResponseCorrespondsToJobOrderRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as JobResponseCorrespondsToJobOrderRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}