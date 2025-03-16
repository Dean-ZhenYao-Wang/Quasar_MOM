namespace MOM.Domain.Common.Relationship.isa95.JobResponseData
{
    public class JobResponseDataContainsRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.WorkPerformance.JobResponseData>, IEquatable<JobResponseDataContainsRelationship>
    {
        public JobResponseDataContainsRelationship()
        {
            Name = "contains";
        }

        public JobResponseDataContainsRelationship(Domain.isa95.CommonObjectModels.Part4.WorkPerformance.JobResponseData source, Domain.isa95.CommonObjectModels.Part4.WorkPerformance.JobResponseData target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public JobResponseDataContainsRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as JobResponseDataContainsRelationship);
        }

        public bool Equals(JobResponseDataContainsRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(JobResponseDataContainsRelationship? left, JobResponseDataContainsRelationship? right)
        {
            return EqualityComparer<JobResponseDataContainsRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(JobResponseDataContainsRelationship? left, JobResponseDataContainsRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as JobResponseDataContainsRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}