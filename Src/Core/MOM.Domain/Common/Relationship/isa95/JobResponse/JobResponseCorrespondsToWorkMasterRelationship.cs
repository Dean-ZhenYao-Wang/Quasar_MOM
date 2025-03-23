namespace MOM.Domain.Common.Relationship.isa95.JobResponse
{
    public class JobResponseCorrespondsToWorkMasterRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.WorkDefinition.WorkMaster>, IEquatable<JobResponseCorrespondsToWorkMasterRelationship>
    {
        public JobResponseCorrespondsToWorkMasterRelationship()
        {
            Name = "correspondsToWorkMaster";
        }

        public JobResponseCorrespondsToWorkMasterRelationship(Domain.isa95.CommonObjectModels.Part4.WorkPerformance.JobResponse source, Domain.isa95.CommonObjectModels.Part4.WorkDefinition.WorkMaster target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public JobResponseCorrespondsToWorkMasterRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as JobResponseCorrespondsToWorkMasterRelationship);
        }

        public bool Equals(JobResponseCorrespondsToWorkMasterRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(JobResponseCorrespondsToWorkMasterRelationship? left, JobResponseCorrespondsToWorkMasterRelationship? right)
        {
            return EqualityComparer<JobResponseCorrespondsToWorkMasterRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(JobResponseCorrespondsToWorkMasterRelationship? left, JobResponseCorrespondsToWorkMasterRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as JobResponseCorrespondsToWorkMasterRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}