namespace MOM.Domain.Common.Relationship.isa95.EquipmentCapability
{
    public class EquipmentCapabilityOperationalLocationRelRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsCapability.EquipmentCapability, Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation>, IEquatable<EquipmentCapabilityOperationalLocationRelRelationship>
    {
        public EquipmentCapabilityOperationalLocationRelRelationship()
        {
            Name = "operationalLocationRel";
        }

        public EquipmentCapabilityOperationalLocationRelRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsCapability.EquipmentCapability source, Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public EquipmentCapabilityOperationalLocationRelRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentCapabilityOperationalLocationRelRelationship);
        }

        public bool Equals(EquipmentCapabilityOperationalLocationRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(EquipmentCapabilityOperationalLocationRelRelationship? left, EquipmentCapabilityOperationalLocationRelRelationship? right)
        {
            return EqualityComparer<EquipmentCapabilityOperationalLocationRelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(EquipmentCapabilityOperationalLocationRelRelationship? left, EquipmentCapabilityOperationalLocationRelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as EquipmentCapabilityOperationalLocationRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}