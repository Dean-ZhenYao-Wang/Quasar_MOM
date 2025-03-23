namespace MOM.Domain.Common.Relationship.isa95.OperationsCapability
{
    public class OperationsCapabilityIsACollectionOfPhysicalAssetRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsCapability.PhysicalAssetCapability>, IEquatable<OperationsCapabilityIsACollectionOfPhysicalAssetRelationship>
    {
        public OperationsCapabilityIsACollectionOfPhysicalAssetRelationship()
        {
            Name = "isACollectionOfPhysicalAsset";
        }

        public OperationsCapabilityIsACollectionOfPhysicalAssetRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsCapability.OperationsCapability source, Domain.isa95.CommonObjectModels.Part2.OperationsCapability.PhysicalAssetCapability target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationsCapabilityIsACollectionOfPhysicalAssetRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsCapabilityIsACollectionOfPhysicalAssetRelationship);
        }

        public bool Equals(OperationsCapabilityIsACollectionOfPhysicalAssetRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationsCapabilityIsACollectionOfPhysicalAssetRelationship? left, OperationsCapabilityIsACollectionOfPhysicalAssetRelationship? right)
        {
            return EqualityComparer<OperationsCapabilityIsACollectionOfPhysicalAssetRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsCapabilityIsACollectionOfPhysicalAssetRelationship? left, OperationsCapabilityIsACollectionOfPhysicalAssetRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationsCapabilityIsACollectionOfPhysicalAssetRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}