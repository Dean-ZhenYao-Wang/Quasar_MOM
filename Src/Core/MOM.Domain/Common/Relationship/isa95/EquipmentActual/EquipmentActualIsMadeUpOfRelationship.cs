namespace MOM.Domain.Common.Relationship.isa95.EquipmentActual
{
    public class EquipmentActualIsMadeUpOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.EquipmentActual,Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.EquipmentActual>, IEquatable<EquipmentActualIsMadeUpOfRelationship>
    {
        public EquipmentActualIsMadeUpOfRelationship()
        {
            Name = "isMadeUpOf";
        }

        public EquipmentActualIsMadeUpOfRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.EquipmentActual source, Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.EquipmentActual target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public EquipmentActualIsMadeUpOfRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentActualIsMadeUpOfRelationship);
        }

        public bool Equals(EquipmentActualIsMadeUpOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(EquipmentActualIsMadeUpOfRelationship? left, EquipmentActualIsMadeUpOfRelationship? right)
        {
            return EqualityComparer<EquipmentActualIsMadeUpOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(EquipmentActualIsMadeUpOfRelationship? left, EquipmentActualIsMadeUpOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as EquipmentActualIsMadeUpOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}