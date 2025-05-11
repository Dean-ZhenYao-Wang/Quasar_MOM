namespace MOM.Domain.Common.Relationship.isa95.WorkCapability
{
    public class WorkCapabilityIsACollectionOfPhysicalAssetRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsCapability.PhysicalAssetCapability>, IEquatable<WorkCapabilityIsACollectionOfPhysicalAssetRelationship>
    {
        public WorkCapabilityIsACollectionOfPhysicalAssetRelationship()
        {
            Name = "isACollectionOfPhysicalAsset";
        }

        public WorkCapabilityIsACollectionOfPhysicalAssetRelationship(Domain.isa95.CommonObjectModels.Part4.WorkCapability.WorkCapability source, Domain.isa95.CommonObjectModels.Part2.OperationsCapability.PhysicalAssetCapability target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkCapabilityIsACollectionOfPhysicalAssetRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkCapabilityIsACollectionOfPhysicalAssetRelationship);
        }

        public bool Equals(WorkCapabilityIsACollectionOfPhysicalAssetRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkCapabilityIsACollectionOfPhysicalAssetRelationship? left, WorkCapabilityIsACollectionOfPhysicalAssetRelationship? right)
        {
            return EqualityComparer<WorkCapabilityIsACollectionOfPhysicalAssetRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkCapabilityIsACollectionOfPhysicalAssetRelationship? left, WorkCapabilityIsACollectionOfPhysicalAssetRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkCapabilityIsACollectionOfPhysicalAssetRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}