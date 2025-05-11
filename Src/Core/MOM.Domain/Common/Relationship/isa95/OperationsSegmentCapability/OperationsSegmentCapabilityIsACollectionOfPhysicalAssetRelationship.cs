namespace MOM.Domain.Common.Relationship.isa95.OperationsSegmentCapability
{
    public class OperationsSegmentCapabilityIsACollectionOfPhysicalAssetRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsCapability.PhysicalAssetCapability>, IEquatable<OperationsSegmentCapabilityIsACollectionOfPhysicalAssetRelationship>
    {
        public OperationsSegmentCapabilityIsACollectionOfPhysicalAssetRelationship()
        {
            Name = "isACollectionOfPhysicalAsset";
        }

        public OperationsSegmentCapabilityIsACollectionOfPhysicalAssetRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsCapability.OperationsSegmentCapability source, Domain.isa95.CommonObjectModels.Part2.OperationsCapability.PhysicalAssetCapability target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationsSegmentCapabilityIsACollectionOfPhysicalAssetRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsSegmentCapabilityIsACollectionOfPhysicalAssetRelationship);
        }

        public bool Equals(OperationsSegmentCapabilityIsACollectionOfPhysicalAssetRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationsSegmentCapabilityIsACollectionOfPhysicalAssetRelationship? left, OperationsSegmentCapabilityIsACollectionOfPhysicalAssetRelationship? right)
        {
            return EqualityComparer<OperationsSegmentCapabilityIsACollectionOfPhysicalAssetRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsSegmentCapabilityIsACollectionOfPhysicalAssetRelationship? left, OperationsSegmentCapabilityIsACollectionOfPhysicalAssetRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationsSegmentCapabilityIsACollectionOfPhysicalAssetRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}