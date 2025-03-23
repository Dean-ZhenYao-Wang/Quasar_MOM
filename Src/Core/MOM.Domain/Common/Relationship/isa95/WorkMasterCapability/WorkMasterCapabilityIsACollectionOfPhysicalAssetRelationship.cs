namespace MOM.Domain.Common.Relationship.isa95.WorkMasterCapability
{
    public class WorkMasterCapabilityIsACollectionOfPhysicalAssetRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsCapability.PhysicalAssetCapability>, IEquatable<WorkMasterCapabilityIsACollectionOfPhysicalAssetRelationship>
    {
        public WorkMasterCapabilityIsACollectionOfPhysicalAssetRelationship()
        {
            Name = "isACollectionOfPhysicalAsset";
        }

        public WorkMasterCapabilityIsACollectionOfPhysicalAssetRelationship(Domain.isa95.CommonObjectModels.Part4.WorkCapability.WorkMasterCapability source, Domain.isa95.CommonObjectModels.Part2.OperationsCapability.PhysicalAssetCapability target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkMasterCapabilityIsACollectionOfPhysicalAssetRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkMasterCapabilityIsACollectionOfPhysicalAssetRelationship);
        }

        public bool Equals(WorkMasterCapabilityIsACollectionOfPhysicalAssetRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkMasterCapabilityIsACollectionOfPhysicalAssetRelationship? left, WorkMasterCapabilityIsACollectionOfPhysicalAssetRelationship? right)
        {
            return EqualityComparer<WorkMasterCapabilityIsACollectionOfPhysicalAssetRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkMasterCapabilityIsACollectionOfPhysicalAssetRelationship? left, WorkMasterCapabilityIsACollectionOfPhysicalAssetRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkMasterCapabilityIsACollectionOfPhysicalAssetRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}