namespace MOM.Domain.Common.Relationship.isa95.JobResponse
{
    public class JobResponseCorrespondsToWorkDirectiveRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.WorkDefinition.WorkDirective>, IEquatable<JobResponseCorrespondsToWorkDirectiveRelationship>
    {
        public JobResponseCorrespondsToWorkDirectiveRelationship()
        {
            Name = "correspondsToWorkDirective";
        }

        public JobResponseCorrespondsToWorkDirectiveRelationship(Domain.isa95.CommonObjectModels.Part4.WorkPerformance.JobResponse source, Domain.isa95.CommonObjectModels.Part4.WorkDefinition.WorkDirective target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public JobResponseCorrespondsToWorkDirectiveRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as JobResponseCorrespondsToWorkDirectiveRelationship);
        }

        public bool Equals(JobResponseCorrespondsToWorkDirectiveRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(JobResponseCorrespondsToWorkDirectiveRelationship? left, JobResponseCorrespondsToWorkDirectiveRelationship? right)
        {
            return EqualityComparer<JobResponseCorrespondsToWorkDirectiveRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(JobResponseCorrespondsToWorkDirectiveRelationship? left, JobResponseCorrespondsToWorkDirectiveRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as JobResponseCorrespondsToWorkDirectiveRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}