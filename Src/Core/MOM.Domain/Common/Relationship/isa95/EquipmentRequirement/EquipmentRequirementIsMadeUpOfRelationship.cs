namespace MOM.Domain.Common.Relationship.isa95.EquipmentRequirement
{
    public class EquipmentRequirementIsMadeUpOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.EquipmentRequirement>, IEquatable<EquipmentRequirementIsMadeUpOfRelationship>
    {
        public EquipmentRequirementIsMadeUpOfRelationship()
        {
            Name = "isMadeUpOf";
        }

        public EquipmentRequirementIsMadeUpOfRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.EquipmentRequirement source, Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.EquipmentRequirement target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public EquipmentRequirementIsMadeUpOfRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentRequirementIsMadeUpOfRelationship);
        }

        public bool Equals(EquipmentRequirementIsMadeUpOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(EquipmentRequirementIsMadeUpOfRelationship? left, EquipmentRequirementIsMadeUpOfRelationship? right)
        {
            return EqualityComparer<EquipmentRequirementIsMadeUpOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(EquipmentRequirementIsMadeUpOfRelationship? left, EquipmentRequirementIsMadeUpOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as EquipmentRequirementIsMadeUpOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}