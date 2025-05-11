namespace MOM.Domain.Common.Relationship.isa95.EquipmentRequirementProperty
{
    public class EquipmentRequirementPropertyContainsRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.EquipmentRequirementProperty>, IEquatable<EquipmentRequirementPropertyContainsRelationship>
    {
        public EquipmentRequirementPropertyContainsRelationship()
        {
            Name = "contains";
        }

        public EquipmentRequirementPropertyContainsRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.EquipmentRequirementProperty source, Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.EquipmentRequirementProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public EquipmentRequirementPropertyContainsRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentRequirementPropertyContainsRelationship);
        }

        public bool Equals(EquipmentRequirementPropertyContainsRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(EquipmentRequirementPropertyContainsRelationship? left, EquipmentRequirementPropertyContainsRelationship? right)
        {
            return EqualityComparer<EquipmentRequirementPropertyContainsRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(EquipmentRequirementPropertyContainsRelationship? left, EquipmentRequirementPropertyContainsRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as EquipmentRequirementPropertyContainsRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}