namespace MOM.Domain.Common.Relationship.isa95.WorkCapability
{
    public class WorkCapabilityIsACollectionOfWorkMasterRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.WorkCapability.WorkMasterCapability>, IEquatable<WorkCapabilityIsACollectionOfWorkMasterRelationship>
    {
        public WorkCapabilityIsACollectionOfWorkMasterRelationship()
        {
            Name = "isACollectionOfWorkMaster";
        }

        public WorkCapabilityIsACollectionOfWorkMasterRelationship(Domain.isa95.CommonObjectModels.Part4.WorkCapability.WorkCapability source, Domain.isa95.CommonObjectModels.Part4.WorkCapability.WorkMasterCapability target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkCapabilityIsACollectionOfWorkMasterRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkCapabilityIsACollectionOfWorkMasterRelationship);
        }

        public bool Equals(WorkCapabilityIsACollectionOfWorkMasterRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkCapabilityIsACollectionOfWorkMasterRelationship? left, WorkCapabilityIsACollectionOfWorkMasterRelationship? right)
        {
            return EqualityComparer<WorkCapabilityIsACollectionOfWorkMasterRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkCapabilityIsACollectionOfWorkMasterRelationship? left, WorkCapabilityIsACollectionOfWorkMasterRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkCapabilityIsACollectionOfWorkMasterRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}