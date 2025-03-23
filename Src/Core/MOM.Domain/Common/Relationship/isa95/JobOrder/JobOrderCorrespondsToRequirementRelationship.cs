namespace MOM.Domain.Common.Relationship.isa95.JobOrder
{
    public class JobOrderCorrespondsToRequirementRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.SegmentRequirement>, IEquatable<JobOrderCorrespondsToRequirementRelationship>
    {
        public JobOrderCorrespondsToRequirementRelationship()
        {
            Name = "correspondsToRequirement";
        }

        public JobOrderCorrespondsToRequirementRelationship(Domain.isa95.CommonObjectModels.Part4.WorkSchedule.JobOrder source, Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.SegmentRequirement target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public JobOrderCorrespondsToRequirementRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as JobOrderCorrespondsToRequirementRelationship);
        }

        public bool Equals(JobOrderCorrespondsToRequirementRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(JobOrderCorrespondsToRequirementRelationship? left, JobOrderCorrespondsToRequirementRelationship? right)
        {
            return EqualityComparer<JobOrderCorrespondsToRequirementRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(JobOrderCorrespondsToRequirementRelationship? left, JobOrderCorrespondsToRequirementRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as JobOrderCorrespondsToRequirementRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}