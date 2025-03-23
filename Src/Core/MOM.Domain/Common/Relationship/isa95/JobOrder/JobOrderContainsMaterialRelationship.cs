namespace MOM.Domain.Common.Relationship.isa95.JobOrder
{
    public class JobOrderContainsMaterialRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.MaterialRequirement>, IEquatable<JobOrderContainsMaterialRelationship>
    {
        public JobOrderContainsMaterialRelationship()
        {
            Name = "containsMaterial";
        }

        public JobOrderContainsMaterialRelationship(Domain.isa95.CommonObjectModels.Part4.WorkSchedule.JobOrder source, Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.MaterialRequirement target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public JobOrderContainsMaterialRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as JobOrderContainsMaterialRelationship);
        }

        public bool Equals(JobOrderContainsMaterialRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(JobOrderContainsMaterialRelationship? left, JobOrderContainsMaterialRelationship? right)
        {
            return EqualityComparer<JobOrderContainsMaterialRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(JobOrderContainsMaterialRelationship? left, JobOrderContainsMaterialRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as JobOrderContainsMaterialRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}