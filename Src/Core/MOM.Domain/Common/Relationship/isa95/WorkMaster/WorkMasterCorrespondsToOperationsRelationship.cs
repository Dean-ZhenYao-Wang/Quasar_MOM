namespace MOM.Domain.Common.Relationship.isa95.WorkMaster
{
    public class WorkMasterCorrespondsToOperationsRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsSegment>, IEquatable<WorkMasterCorrespondsToOperationsRelationship>
    {
        public WorkMasterCorrespondsToOperationsRelationship()
        {
            Name = "correspondsToOperations";
        }

        public WorkMasterCorrespondsToOperationsRelationship(Domain.isa95.CommonObjectModels.Part4.WorkDefinition.WorkMaster source, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsSegment target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkMasterCorrespondsToOperationsRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkMasterCorrespondsToOperationsRelationship);
        }

        public bool Equals(WorkMasterCorrespondsToOperationsRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkMasterCorrespondsToOperationsRelationship? left, WorkMasterCorrespondsToOperationsRelationship? right)
        {
            return EqualityComparer<WorkMasterCorrespondsToOperationsRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkMasterCorrespondsToOperationsRelationship? left, WorkMasterCorrespondsToOperationsRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkMasterCorrespondsToOperationsRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}