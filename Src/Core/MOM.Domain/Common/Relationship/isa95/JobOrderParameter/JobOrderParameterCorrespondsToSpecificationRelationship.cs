namespace MOM.Domain.Common.Relationship.isa95.JobOrderParameter
{
    public class JobOrderParameterCorrespondsToSpecificationRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.ParameterSpecification>, IEquatable<JobOrderParameterCorrespondsToSpecificationRelationship>
    {
        public JobOrderParameterCorrespondsToSpecificationRelationship()
        {
            Name = "correspondsToSpecification";
        }

        public JobOrderParameterCorrespondsToSpecificationRelationship(Domain.isa95.CommonObjectModels.Part4.WorkSchedule.JobOrderParameter source, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.ParameterSpecification target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public JobOrderParameterCorrespondsToSpecificationRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as JobOrderParameterCorrespondsToSpecificationRelationship);
        }

        public bool Equals(JobOrderParameterCorrespondsToSpecificationRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(JobOrderParameterCorrespondsToSpecificationRelationship? left, JobOrderParameterCorrespondsToSpecificationRelationship? right)
        {
            return EqualityComparer<JobOrderParameterCorrespondsToSpecificationRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(JobOrderParameterCorrespondsToSpecificationRelationship? left, JobOrderParameterCorrespondsToSpecificationRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as JobOrderParameterCorrespondsToSpecificationRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}