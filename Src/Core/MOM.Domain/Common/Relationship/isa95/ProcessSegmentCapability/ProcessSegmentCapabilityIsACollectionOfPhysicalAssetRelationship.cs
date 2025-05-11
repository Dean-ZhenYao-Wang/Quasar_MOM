namespace MOM.Domain.Common.Relationship.isa95.ProcessSegmentCapability
{
    public class ProcessSegmentCapabilityIsACollectionOfPhysicalAssetRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsCapability.PhysicalAssetCapability>, IEquatable<ProcessSegmentCapabilityIsACollectionOfPhysicalAssetRelationship>
    {
        public ProcessSegmentCapabilityIsACollectionOfPhysicalAssetRelationship()
        {
            Name = "isACollectionOfPhysicalAsset";
        }

        public ProcessSegmentCapabilityIsACollectionOfPhysicalAssetRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsCapability.ProcessSegmentCapability source, Domain.isa95.CommonObjectModels.Part2.OperationsCapability.PhysicalAssetCapability target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public ProcessSegmentCapabilityIsACollectionOfPhysicalAssetRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as ProcessSegmentCapabilityIsACollectionOfPhysicalAssetRelationship);
        }

        public bool Equals(ProcessSegmentCapabilityIsACollectionOfPhysicalAssetRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(ProcessSegmentCapabilityIsACollectionOfPhysicalAssetRelationship? left, ProcessSegmentCapabilityIsACollectionOfPhysicalAssetRelationship? right)
        {
            return EqualityComparer<ProcessSegmentCapabilityIsACollectionOfPhysicalAssetRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(ProcessSegmentCapabilityIsACollectionOfPhysicalAssetRelationship? left, ProcessSegmentCapabilityIsACollectionOfPhysicalAssetRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as ProcessSegmentCapabilityIsACollectionOfPhysicalAssetRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}