namespace MOM.Domain.Common.Relationship.isa95.JobOrder
{
    public class JobOrderCorrespondsToWorkMasterRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.WorkDefinition.WorkMaster>, IEquatable<JobOrderCorrespondsToWorkMasterRelationship>
    {
        public JobOrderCorrespondsToWorkMasterRelationship()
        {
            Name = "correspondsToWorkMaster";
        }

        public JobOrderCorrespondsToWorkMasterRelationship(Domain.isa95.CommonObjectModels.Part4.WorkSchedule.JobOrder source, Domain.isa95.CommonObjectModels.Part4.WorkDefinition.WorkMaster target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public JobOrderCorrespondsToWorkMasterRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as JobOrderCorrespondsToWorkMasterRelationship);
        }

        public bool Equals(JobOrderCorrespondsToWorkMasterRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(JobOrderCorrespondsToWorkMasterRelationship? left, JobOrderCorrespondsToWorkMasterRelationship? right)
        {
            return EqualityComparer<JobOrderCorrespondsToWorkMasterRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(JobOrderCorrespondsToWorkMasterRelationship? left, JobOrderCorrespondsToWorkMasterRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as JobOrderCorrespondsToWorkMasterRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}