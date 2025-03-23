namespace MOM.Domain.Common.Relationship.isa95.EquipmentCapability
{
    public class EquipmentCapabilityIsMadeUpOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsCapability.EquipmentCapability>, IEquatable<EquipmentCapabilityIsMadeUpOfRelationship>
    {
        public EquipmentCapabilityIsMadeUpOfRelationship()
        {
            Name = "isMadeUpOf";
        }

        public EquipmentCapabilityIsMadeUpOfRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsCapability.EquipmentCapability source, Domain.isa95.CommonObjectModels.Part2.OperationsCapability.EquipmentCapability target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public EquipmentCapabilityIsMadeUpOfRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentCapabilityIsMadeUpOfRelationship);
        }

        public bool Equals(EquipmentCapabilityIsMadeUpOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(EquipmentCapabilityIsMadeUpOfRelationship? left, EquipmentCapabilityIsMadeUpOfRelationship? right)
        {
            return EqualityComparer<EquipmentCapabilityIsMadeUpOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(EquipmentCapabilityIsMadeUpOfRelationship? left, EquipmentCapabilityIsMadeUpOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as EquipmentCapabilityIsMadeUpOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}