namespace MOM.Domain.Common.Relationship.isa95.Equipment
{
    public class EquipmentHierarchyScopeRelRelationship : Relationship<Domain.isa95.CommonObjectModels.HierarchyScope>, IEquatable<EquipmentHierarchyScopeRelRelationship>
    {
        public EquipmentHierarchyScopeRelRelationship()
        {
            Name = "hierarchyScopeRel";
        }

        public EquipmentHierarchyScopeRelRelationship(Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.Equipment source, Domain.isa95.CommonObjectModels.HierarchyScope target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public EquipmentHierarchyScopeRelRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentHierarchyScopeRelRelationship);
        }

        public bool Equals(EquipmentHierarchyScopeRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(EquipmentHierarchyScopeRelRelationship? left, EquipmentHierarchyScopeRelRelationship? right)
        {
            return EqualityComparer<EquipmentHierarchyScopeRelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(EquipmentHierarchyScopeRelRelationship? left, EquipmentHierarchyScopeRelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as EquipmentHierarchyScopeRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}