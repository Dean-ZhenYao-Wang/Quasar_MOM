namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetCapability
{
    public class PhysicalAssetCapabilityHierarchyScopeRelRelationship : Relationship<Domain.isa95.CommonObjectModels.HierarchyScope>, IEquatable<PhysicalAssetCapabilityHierarchyScopeRelRelationship>
    {
        public PhysicalAssetCapabilityHierarchyScopeRelRelationship()
        {
            Name = "hierarchyScopeRel";
        }

        public PhysicalAssetCapabilityHierarchyScopeRelRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsCapability.PhysicalAssetCapability source, Domain.isa95.CommonObjectModels.HierarchyScope target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PhysicalAssetCapabilityHierarchyScopeRelRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PhysicalAssetCapabilityHierarchyScopeRelRelationship);
        }

        public bool Equals(PhysicalAssetCapabilityHierarchyScopeRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PhysicalAssetCapabilityHierarchyScopeRelRelationship? left, PhysicalAssetCapabilityHierarchyScopeRelRelationship? right)
        {
            return EqualityComparer<PhysicalAssetCapabilityHierarchyScopeRelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PhysicalAssetCapabilityHierarchyScopeRelRelationship? left, PhysicalAssetCapabilityHierarchyScopeRelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PhysicalAssetCapabilityHierarchyScopeRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}