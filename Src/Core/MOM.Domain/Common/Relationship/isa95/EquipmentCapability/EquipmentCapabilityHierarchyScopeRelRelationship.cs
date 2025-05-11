namespace MOM.Domain.Common.Relationship.isa95.EquipmentCapability
{
    public class EquipmentCapabilityHierarchyScopeRelRelationship : Relationship<Domain.isa95.CommonObjectModels.HierarchyScope>, IEquatable<EquipmentCapabilityHierarchyScopeRelRelationship>
    {
        public EquipmentCapabilityHierarchyScopeRelRelationship()
        {
            Name = "hierarchyScopeRel";
        }

        public EquipmentCapabilityHierarchyScopeRelRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsCapability.EquipmentCapability source, Domain.isa95.CommonObjectModels.HierarchyScope target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public EquipmentCapabilityHierarchyScopeRelRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentCapabilityHierarchyScopeRelRelationship);
        }

        public bool Equals(EquipmentCapabilityHierarchyScopeRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(EquipmentCapabilityHierarchyScopeRelRelationship? left, EquipmentCapabilityHierarchyScopeRelRelationship? right)
        {
            return EqualityComparer<EquipmentCapabilityHierarchyScopeRelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(EquipmentCapabilityHierarchyScopeRelRelationship? left, EquipmentCapabilityHierarchyScopeRelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as EquipmentCapabilityHierarchyScopeRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}