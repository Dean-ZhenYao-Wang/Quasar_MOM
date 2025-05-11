namespace MOM.Domain.Common.Relationship.isa95.EquipmentActual
{
    public class EquipmentActualHasValuesOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.EquipmentActualProperty>, IEquatable<EquipmentActualHasValuesOfRelationship>
    {
        public EquipmentActualHasValuesOfRelationship()
        {
            Name = "hasValuesOf";
        }

        public EquipmentActualHasValuesOfRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.EquipmentActual source, Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.EquipmentActualProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public EquipmentActualHasValuesOfRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentActualHasValuesOfRelationship);
        }

        public bool Equals(EquipmentActualHasValuesOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(EquipmentActualHasValuesOfRelationship? left, EquipmentActualHasValuesOfRelationship? right)
        {
            return EqualityComparer<EquipmentActualHasValuesOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(EquipmentActualHasValuesOfRelationship? left, EquipmentActualHasValuesOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as EquipmentActualHasValuesOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}