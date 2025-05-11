namespace MOM.Domain.Common.Relationship.isa95.EquipmentRequirement
{
    public class EquipmentRequirementHierarchyScopeRelRelationship : Relationship<Domain.isa95.CommonObjectModels.HierarchyScope>, IEquatable<EquipmentRequirementHierarchyScopeRelRelationship>
    {
        public EquipmentRequirementHierarchyScopeRelRelationship()
        {
            Name = "hierarchyScopeRel";
        }

        public EquipmentRequirementHierarchyScopeRelRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.EquipmentRequirement source, Domain.isa95.CommonObjectModels.HierarchyScope target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public EquipmentRequirementHierarchyScopeRelRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentRequirementHierarchyScopeRelRelationship);
        }

        public bool Equals(EquipmentRequirementHierarchyScopeRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(EquipmentRequirementHierarchyScopeRelRelationship? left, EquipmentRequirementHierarchyScopeRelRelationship? right)
        {
            return EqualityComparer<EquipmentRequirementHierarchyScopeRelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(EquipmentRequirementHierarchyScopeRelRelationship? left, EquipmentRequirementHierarchyScopeRelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as EquipmentRequirementHierarchyScopeRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}