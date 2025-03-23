namespace MOM.Domain.Common.Relationship.isa95.OperationsSegmentCapability
{
    public class OperationsSegmentCapabilityIsACollectionOfMaterialRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsCapability.MaterialCapability>, IEquatable<OperationsSegmentCapabilityIsACollectionOfMaterialRelationship>
    {
        public OperationsSegmentCapabilityIsACollectionOfMaterialRelationship()
        {
            Name = "isACollectionOfMaterial";
        }

        public OperationsSegmentCapabilityIsACollectionOfMaterialRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsCapability.OperationsSegmentCapability source, Domain.isa95.CommonObjectModels.Part2.OperationsCapability.MaterialCapability target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationsSegmentCapabilityIsACollectionOfMaterialRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsSegmentCapabilityIsACollectionOfMaterialRelationship);
        }

        public bool Equals(OperationsSegmentCapabilityIsACollectionOfMaterialRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationsSegmentCapabilityIsACollectionOfMaterialRelationship? left, OperationsSegmentCapabilityIsACollectionOfMaterialRelationship? right)
        {
            return EqualityComparer<OperationsSegmentCapabilityIsACollectionOfMaterialRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsSegmentCapabilityIsACollectionOfMaterialRelationship? left, OperationsSegmentCapabilityIsACollectionOfMaterialRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationsSegmentCapabilityIsACollectionOfMaterialRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}