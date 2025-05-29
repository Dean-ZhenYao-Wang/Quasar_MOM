namespace MOM.Domain.Common.Relationship.isa95.JobOrderParameter
{
    public class JobOrderParameterCorrespondsToProcessRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.WorkSchedule.JobOrderParameter,Domain.isa95.CommonObjectModels.Part2.ProcessSegment.ProcessSegmentParameter>, IEquatable<JobOrderParameterCorrespondsToProcessRelationship>
    {
        public JobOrderParameterCorrespondsToProcessRelationship()
        {
            Name = "correspondsToProcess";
        }

        public JobOrderParameterCorrespondsToProcessRelationship(Domain.isa95.CommonObjectModels.Part4.WorkSchedule.JobOrderParameter source, Domain.isa95.CommonObjectModels.Part2.ProcessSegment.ProcessSegmentParameter target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public JobOrderParameterCorrespondsToProcessRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as JobOrderParameterCorrespondsToProcessRelationship);
        }

        public bool Equals(JobOrderParameterCorrespondsToProcessRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(JobOrderParameterCorrespondsToProcessRelationship? left, JobOrderParameterCorrespondsToProcessRelationship? right)
        {
            return EqualityComparer<JobOrderParameterCorrespondsToProcessRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(JobOrderParameterCorrespondsToProcessRelationship? left, JobOrderParameterCorrespondsToProcessRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as JobOrderParameterCorrespondsToProcessRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}