namespace MOM.Domain.Common.Relationship.isa95.WorkMasterCapability
{
    public class WorkMasterCapabilityCorrespondsToRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.WorkDefinition.WorkMaster>, IEquatable<WorkMasterCapabilityCorrespondsToRelationship>
    {
        public WorkMasterCapabilityCorrespondsToRelationship()
        {
            Name = "correspondsTo";
        }

        public WorkMasterCapabilityCorrespondsToRelationship(Domain.isa95.CommonObjectModels.Part4.WorkCapability.WorkMasterCapability source, Domain.isa95.CommonObjectModels.Part4.WorkDefinition.WorkMaster target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkMasterCapabilityCorrespondsToRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkMasterCapabilityCorrespondsToRelationship);
        }

        public bool Equals(WorkMasterCapabilityCorrespondsToRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkMasterCapabilityCorrespondsToRelationship? left, WorkMasterCapabilityCorrespondsToRelationship? right)
        {
            return EqualityComparer<WorkMasterCapabilityCorrespondsToRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkMasterCapabilityCorrespondsToRelationship? left, WorkMasterCapabilityCorrespondsToRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkMasterCapabilityCorrespondsToRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}