namespace MOM.Domain.Common.Relationship.isa95.JobOrder
{
    public class JobOrderContainsParameterRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.WorkSchedule.JobOrderParameter>, IEquatable<JobOrderContainsParameterRelationship>
    {
        public JobOrderContainsParameterRelationship()
        {
            Name = "containsParameter";
        }

        public JobOrderContainsParameterRelationship(Domain.isa95.CommonObjectModels.Part4.WorkSchedule.JobOrder source, Domain.isa95.CommonObjectModels.Part4.WorkSchedule.JobOrderParameter target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public JobOrderContainsParameterRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as JobOrderContainsParameterRelationship);
        }

        public bool Equals(JobOrderContainsParameterRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(JobOrderContainsParameterRelationship? left, JobOrderContainsParameterRelationship? right)
        {
            return EqualityComparer<JobOrderContainsParameterRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(JobOrderContainsParameterRelationship? left, JobOrderContainsParameterRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as JobOrderContainsParameterRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}