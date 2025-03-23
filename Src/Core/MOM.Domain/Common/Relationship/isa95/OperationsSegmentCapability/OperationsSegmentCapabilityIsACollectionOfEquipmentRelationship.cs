namespace MOM.Domain.Common.Relationship.isa95.OperationsSegmentCapability
{
    public class OperationsSegmentCapabilityIsACollectionOfEquipmentRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsCapability.EquipmentCapability>, IEquatable<OperationsSegmentCapabilityIsACollectionOfEquipmentRelationship>
    {
        public OperationsSegmentCapabilityIsACollectionOfEquipmentRelationship()
        {
            Name = "isACollectionOfEquipment";
        }

        public OperationsSegmentCapabilityIsACollectionOfEquipmentRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsCapability.OperationsSegmentCapability source, Domain.isa95.CommonObjectModels.Part2.OperationsCapability.EquipmentCapability target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationsSegmentCapabilityIsACollectionOfEquipmentRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsSegmentCapabilityIsACollectionOfEquipmentRelationship);
        }

        public bool Equals(OperationsSegmentCapabilityIsACollectionOfEquipmentRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationsSegmentCapabilityIsACollectionOfEquipmentRelationship? left, OperationsSegmentCapabilityIsACollectionOfEquipmentRelationship? right)
        {
            return EqualityComparer<OperationsSegmentCapabilityIsACollectionOfEquipmentRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsSegmentCapabilityIsACollectionOfEquipmentRelationship? left, OperationsSegmentCapabilityIsACollectionOfEquipmentRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationsSegmentCapabilityIsACollectionOfEquipmentRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}