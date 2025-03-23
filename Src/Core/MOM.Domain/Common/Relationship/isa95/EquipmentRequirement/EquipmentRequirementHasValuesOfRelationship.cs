namespace MOM.Domain.Common.Relationship.isa95.EquipmentRequirement
{
    public class EquipmentRequirementHasValuesOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.EquipmentRequirementProperty>, IEquatable<EquipmentRequirementHasValuesOfRelationship>
    {
        public EquipmentRequirementHasValuesOfRelationship()
        {
            Name = "hasValuesOf";
        }

        public EquipmentRequirementHasValuesOfRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.EquipmentRequirement source, Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.EquipmentRequirementProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public EquipmentRequirementHasValuesOfRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentRequirementHasValuesOfRelationship);
        }

        public bool Equals(EquipmentRequirementHasValuesOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(EquipmentRequirementHasValuesOfRelationship? left, EquipmentRequirementHasValuesOfRelationship? right)
        {
            return EqualityComparer<EquipmentRequirementHasValuesOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(EquipmentRequirementHasValuesOfRelationship? left, EquipmentRequirementHasValuesOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as EquipmentRequirementHasValuesOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}