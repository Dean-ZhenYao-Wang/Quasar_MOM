namespace MOM.Domain.Common.Relationship.isa95.EquipmentCapabilityProperty
{
    public class EquipmentCapabilityPropertyContainsRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsCapability.EquipmentCapabilityProperty>, IEquatable<EquipmentCapabilityPropertyContainsRelationship>
    {
        public EquipmentCapabilityPropertyContainsRelationship()
        {
            Name = "contains";
        }

        public EquipmentCapabilityPropertyContainsRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsCapability.EquipmentCapabilityProperty source, Domain.isa95.CommonObjectModels.Part2.OperationsCapability.EquipmentCapabilityProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public EquipmentCapabilityPropertyContainsRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentCapabilityPropertyContainsRelationship);
        }

        public bool Equals(EquipmentCapabilityPropertyContainsRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(EquipmentCapabilityPropertyContainsRelationship? left, EquipmentCapabilityPropertyContainsRelationship? right)
        {
            return EqualityComparer<EquipmentCapabilityPropertyContainsRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(EquipmentCapabilityPropertyContainsRelationship? left, EquipmentCapabilityPropertyContainsRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as EquipmentCapabilityPropertyContainsRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}