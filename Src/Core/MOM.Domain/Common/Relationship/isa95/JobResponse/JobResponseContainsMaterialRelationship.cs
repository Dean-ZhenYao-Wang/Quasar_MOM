namespace MOM.Domain.Common.Relationship.isa95.JobResponse
{
    public class JobResponseContainsMaterialRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.MaterialActual>, IEquatable<JobResponseContainsMaterialRelationship>
    {
        public JobResponseContainsMaterialRelationship()
        {
            Name = "containsMaterial";
        }

        public JobResponseContainsMaterialRelationship(Domain.isa95.CommonObjectModels.Part4.WorkPerformance.JobResponse source, Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.MaterialActual target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public JobResponseContainsMaterialRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as JobResponseContainsMaterialRelationship);
        }

        public bool Equals(JobResponseContainsMaterialRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(JobResponseContainsMaterialRelationship? left, JobResponseContainsMaterialRelationship? right)
        {
            return EqualityComparer<JobResponseContainsMaterialRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(JobResponseContainsMaterialRelationship? left, JobResponseContainsMaterialRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as JobResponseContainsMaterialRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}