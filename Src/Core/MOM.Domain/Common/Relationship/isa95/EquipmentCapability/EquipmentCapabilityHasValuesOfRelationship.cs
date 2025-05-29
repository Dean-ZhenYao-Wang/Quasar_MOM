namespace MOM.Domain.Common.Relationship.isa95.EquipmentCapability
{
    public class EquipmentCapabilityHasValuesOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsCapability.EquipmentCapability, Domain.isa95.CommonObjectModels.Part2.OperationsCapability.EquipmentCapabilityProperty>, IEquatable<EquipmentCapabilityHasValuesOfRelationship>
    {
        public EquipmentCapabilityHasValuesOfRelationship()
        {
            Name = "hasValuesOf";
        }

        public EquipmentCapabilityHasValuesOfRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsCapability.EquipmentCapability source, Domain.isa95.CommonObjectModels.Part2.OperationsCapability.EquipmentCapabilityProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public EquipmentCapabilityHasValuesOfRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentCapabilityHasValuesOfRelationship);
        }

        public bool Equals(EquipmentCapabilityHasValuesOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(EquipmentCapabilityHasValuesOfRelationship? left, EquipmentCapabilityHasValuesOfRelationship? right)
        {
            return EqualityComparer<EquipmentCapabilityHasValuesOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(EquipmentCapabilityHasValuesOfRelationship? left, EquipmentCapabilityHasValuesOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as EquipmentCapabilityHasValuesOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}