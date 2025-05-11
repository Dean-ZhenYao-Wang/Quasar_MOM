namespace MOM.Domain.Common.Relationship.isa95.JobResponse
{
    public class JobResponseCorrespondsToSpecificationNodeRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationNode>, IEquatable<JobResponseCorrespondsToSpecificationNodeRelationship>
    {
        public JobResponseCorrespondsToSpecificationNodeRelationship()
        {
            Name = "correspondsToSpecificationNode";
        }

        public JobResponseCorrespondsToSpecificationNodeRelationship(Domain.isa95.CommonObjectModels.Part4.WorkPerformance.JobResponse source, Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationNode target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public JobResponseCorrespondsToSpecificationNodeRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as JobResponseCorrespondsToSpecificationNodeRelationship);
        }

        public bool Equals(JobResponseCorrespondsToSpecificationNodeRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(JobResponseCorrespondsToSpecificationNodeRelationship? left, JobResponseCorrespondsToSpecificationNodeRelationship? right)
        {
            return EqualityComparer<JobResponseCorrespondsToSpecificationNodeRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(JobResponseCorrespondsToSpecificationNodeRelationship? left, JobResponseCorrespondsToSpecificationNodeRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as JobResponseCorrespondsToSpecificationNodeRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}