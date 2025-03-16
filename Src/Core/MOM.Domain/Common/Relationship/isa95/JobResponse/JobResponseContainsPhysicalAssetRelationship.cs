namespace MOM.Domain.Common.Relationship.isa95.JobResponse
{
    public class JobResponseContainsPhysicalAssetRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.PhysicalAssetActual>, IEquatable<JobResponseContainsPhysicalAssetRelationship>
    {
        public JobResponseContainsPhysicalAssetRelationship()
        {
            Name = "containsPhysicalAsset";
        }

        public JobResponseContainsPhysicalAssetRelationship(Domain.isa95.CommonObjectModels.Part4.WorkPerformance.JobResponse source, Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.PhysicalAssetActual target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public JobResponseContainsPhysicalAssetRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as JobResponseContainsPhysicalAssetRelationship);
        }

        public bool Equals(JobResponseContainsPhysicalAssetRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(JobResponseContainsPhysicalAssetRelationship? left, JobResponseContainsPhysicalAssetRelationship? right)
        {
            return EqualityComparer<JobResponseContainsPhysicalAssetRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(JobResponseContainsPhysicalAssetRelationship? left, JobResponseContainsPhysicalAssetRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as JobResponseContainsPhysicalAssetRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}