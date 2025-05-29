namespace MOM.Domain.Common.Relationship.isa95.EquipmentActual
{
    public class EquipmentActualHierarchyScopeRelRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.EquipmentActua,Domain.isa95.CommonObjectModels.HierarchyScope>, IEquatable<EquipmentActualHierarchyScopeRelRelationship>
    {
        public EquipmentActualHierarchyScopeRelRelationship()
        {
            Name = "hierarchyScopeRel";
        }

        public EquipmentActualHierarchyScopeRelRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.EquipmentActual source, Domain.isa95.CommonObjectModels.HierarchyScope target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public EquipmentActualHierarchyScopeRelRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentActualHierarchyScopeRelRelationship);
        }

        public bool Equals(EquipmentActualHierarchyScopeRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(EquipmentActualHierarchyScopeRelRelationship? left, EquipmentActualHierarchyScopeRelRelationship? right)
        {
            return EqualityComparer<EquipmentActualHierarchyScopeRelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(EquipmentActualHierarchyScopeRelRelationship? left, EquipmentActualHierarchyScopeRelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as EquipmentActualHierarchyScopeRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}