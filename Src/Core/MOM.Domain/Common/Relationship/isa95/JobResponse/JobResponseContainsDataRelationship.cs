namespace MOM.Domain.Common.Relationship.isa95.JobResponse
{
    public class JobResponseContainsDataRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.WorkPerformance.JobResponseData>, IEquatable<JobResponseContainsDataRelationship>
    {
        public JobResponseContainsDataRelationship()
        {
            Name = "containsData";
        }

        public JobResponseContainsDataRelationship(Domain.isa95.CommonObjectModels.Part4.WorkPerformance.JobResponse source, Domain.isa95.CommonObjectModels.Part4.WorkPerformance.JobResponseData target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public JobResponseContainsDataRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as JobResponseContainsDataRelationship);
        }

        public bool Equals(JobResponseContainsDataRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(JobResponseContainsDataRelationship? left, JobResponseContainsDataRelationship? right)
        {
            return EqualityComparer<JobResponseContainsDataRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(JobResponseContainsDataRelationship? left, JobResponseContainsDataRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as JobResponseContainsDataRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}