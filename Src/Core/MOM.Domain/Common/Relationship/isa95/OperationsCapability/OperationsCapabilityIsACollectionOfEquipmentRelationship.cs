namespace MOM.Domain.Common.Relationship.isa95.OperationsCapability
{
    public class OperationsCapabilityIsACollectionOfEquipmentRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsCapability.EquipmentCapability>, IEquatable<OperationsCapabilityIsACollectionOfEquipmentRelationship>
    {
        public OperationsCapabilityIsACollectionOfEquipmentRelationship()
        {
            Name = "isACollectionOfEquipment";
        }

        public OperationsCapabilityIsACollectionOfEquipmentRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsCapability.OperationsCapability source, Domain.isa95.CommonObjectModels.Part2.OperationsCapability.EquipmentCapability target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationsCapabilityIsACollectionOfEquipmentRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsCapabilityIsACollectionOfEquipmentRelationship);
        }

        public bool Equals(OperationsCapabilityIsACollectionOfEquipmentRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationsCapabilityIsACollectionOfEquipmentRelationship? left, OperationsCapabilityIsACollectionOfEquipmentRelationship? right)
        {
            return EqualityComparer<OperationsCapabilityIsACollectionOfEquipmentRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsCapabilityIsACollectionOfEquipmentRelationship? left, OperationsCapabilityIsACollectionOfEquipmentRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationsCapabilityIsACollectionOfEquipmentRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}