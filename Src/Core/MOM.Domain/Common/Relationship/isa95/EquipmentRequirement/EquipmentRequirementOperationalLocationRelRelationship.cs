namespace MOM.Domain.Common.Relationship.isa95.EquipmentRequirement
{
    public class EquipmentRequirementOperationalLocationRelRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation>, IEquatable<EquipmentRequirementOperationalLocationRelRelationship>
    {
        public EquipmentRequirementOperationalLocationRelRelationship()
        {
            Name = "operationalLocationRel";
        }

        public EquipmentRequirementOperationalLocationRelRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.EquipmentRequirement source, Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public EquipmentRequirementOperationalLocationRelRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentRequirementOperationalLocationRelRelationship);
        }

        public bool Equals(EquipmentRequirementOperationalLocationRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(EquipmentRequirementOperationalLocationRelRelationship? left, EquipmentRequirementOperationalLocationRelRelationship? right)
        {
            return EqualityComparer<EquipmentRequirementOperationalLocationRelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(EquipmentRequirementOperationalLocationRelRelationship? left, EquipmentRequirementOperationalLocationRelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as EquipmentRequirementOperationalLocationRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}