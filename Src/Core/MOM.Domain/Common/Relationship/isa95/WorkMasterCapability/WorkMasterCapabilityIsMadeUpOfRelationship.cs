namespace MOM.Domain.Common.Relationship.isa95.WorkMasterCapability
{
    public class WorkMasterCapabilityIsMadeUpOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.WorkCapability.WorkMasterCapability>, IEquatable<WorkMasterCapabilityIsMadeUpOfRelationship>
    {
        public WorkMasterCapabilityIsMadeUpOfRelationship()
        {
            Name = "isMadeUpOf";
        }

        public WorkMasterCapabilityIsMadeUpOfRelationship(Domain.isa95.CommonObjectModels.Part4.WorkCapability.WorkMasterCapability source, Domain.isa95.CommonObjectModels.Part4.WorkCapability.WorkMasterCapability target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkMasterCapabilityIsMadeUpOfRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkMasterCapabilityIsMadeUpOfRelationship);
        }

        public bool Equals(WorkMasterCapabilityIsMadeUpOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkMasterCapabilityIsMadeUpOfRelationship? left, WorkMasterCapabilityIsMadeUpOfRelationship? right)
        {
            return EqualityComparer<WorkMasterCapabilityIsMadeUpOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkMasterCapabilityIsMadeUpOfRelationship? left, WorkMasterCapabilityIsMadeUpOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkMasterCapabilityIsMadeUpOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}