namespace MOM.Domain.Common.Relationship.isa95.WorkMaster
{
    public class WorkMasterCorrespondsToProcessRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.ProcessSegment.ProcessSegment>, IEquatable<WorkMasterCorrespondsToProcessRelationship>
    {
        public WorkMasterCorrespondsToProcessRelationship()
        {
            Name = "correspondsToProcess";
        }

        public WorkMasterCorrespondsToProcessRelationship(Domain.isa95.CommonObjectModels.Part4.WorkDefinition.WorkMaster source, Domain.isa95.CommonObjectModels.Part2.ProcessSegment.ProcessSegment target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkMasterCorrespondsToProcessRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkMasterCorrespondsToProcessRelationship);
        }

        public bool Equals(WorkMasterCorrespondsToProcessRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkMasterCorrespondsToProcessRelationship? left, WorkMasterCorrespondsToProcessRelationship? right)
        {
            return EqualityComparer<WorkMasterCorrespondsToProcessRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkMasterCorrespondsToProcessRelationship? left, WorkMasterCorrespondsToProcessRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkMasterCorrespondsToProcessRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}