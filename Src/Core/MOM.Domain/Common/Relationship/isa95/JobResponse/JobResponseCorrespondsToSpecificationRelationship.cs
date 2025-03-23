namespace MOM.Domain.Common.Relationship.isa95.JobResponse
{
    public class JobResponseCorrespondsToSpecificationRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecification>, IEquatable<JobResponseCorrespondsToSpecificationRelationship>
    {
        public JobResponseCorrespondsToSpecificationRelationship()
        {
            Name = "correspondsToSpecification";
        }

        public JobResponseCorrespondsToSpecificationRelationship(Domain.isa95.CommonObjectModels.Part4.WorkPerformance.JobResponse source, Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecification target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public JobResponseCorrespondsToSpecificationRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as JobResponseCorrespondsToSpecificationRelationship);
        }

        public bool Equals(JobResponseCorrespondsToSpecificationRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(JobResponseCorrespondsToSpecificationRelationship? left, JobResponseCorrespondsToSpecificationRelationship? right)
        {
            return EqualityComparer<JobResponseCorrespondsToSpecificationRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(JobResponseCorrespondsToSpecificationRelationship? left, JobResponseCorrespondsToSpecificationRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as JobResponseCorrespondsToSpecificationRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}