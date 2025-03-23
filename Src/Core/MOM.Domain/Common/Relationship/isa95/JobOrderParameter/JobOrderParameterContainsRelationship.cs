namespace MOM.Domain.Common.Relationship.isa95.JobOrderParameter
{
    public class JobOrderParameterContainsRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.WorkSchedule.JobOrderParameter>, IEquatable<JobOrderParameterContainsRelationship>
    {
        public JobOrderParameterContainsRelationship()
        {
            Name = "contains";
        }

        public JobOrderParameterContainsRelationship(Domain.isa95.CommonObjectModels.Part4.WorkSchedule.JobOrderParameter source, Domain.isa95.CommonObjectModels.Part4.WorkSchedule.JobOrderParameter target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public JobOrderParameterContainsRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as JobOrderParameterContainsRelationship);
        }

        public bool Equals(JobOrderParameterContainsRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(JobOrderParameterContainsRelationship? left, JobOrderParameterContainsRelationship? right)
        {
            return EqualityComparer<JobOrderParameterContainsRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(JobOrderParameterContainsRelationship? left, JobOrderParameterContainsRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as JobOrderParameterContainsRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}