namespace MOM.Domain.Common.Relationship.isa95.EquipmentActual
{
    public class EquipmentActualOperationalLocationRelRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation>, IEquatable<EquipmentActualOperationalLocationRelRelationship>
    {
        public EquipmentActualOperationalLocationRelRelationship()
        {
            Name = "operationalLocationRel";
        }

        public EquipmentActualOperationalLocationRelRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.EquipmentActual source, Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public EquipmentActualOperationalLocationRelRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentActualOperationalLocationRelRelationship);
        }

        public bool Equals(EquipmentActualOperationalLocationRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(EquipmentActualOperationalLocationRelRelationship? left, EquipmentActualOperationalLocationRelRelationship? right)
        {
            return EqualityComparer<EquipmentActualOperationalLocationRelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(EquipmentActualOperationalLocationRelRelationship? left, EquipmentActualOperationalLocationRelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as EquipmentActualOperationalLocationRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}