namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetClass
{
    public class PhysicalAssetClassHierarchyScopeRelRelationship : Relationship<MOM.Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAssetClass,Domain.isa95.CommonObjectModels.HierarchyScope>, IEquatable<PhysicalAssetClassHierarchyScopeRelRelationship>
    {
        public PhysicalAssetClassHierarchyScopeRelRelationship()
        {
            Name = "hierarchyScopeRel";
        }

        public PhysicalAssetClassHierarchyScopeRelRelationship(Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAssetClass source, Domain.isa95.CommonObjectModels.HierarchyScope target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PhysicalAssetClassHierarchyScopeRelRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PhysicalAssetClassHierarchyScopeRelRelationship);
        }

        public bool Equals(PhysicalAssetClassHierarchyScopeRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PhysicalAssetClassHierarchyScopeRelRelationship? left, PhysicalAssetClassHierarchyScopeRelRelationship? right)
        {
            return EqualityComparer<PhysicalAssetClassHierarchyScopeRelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PhysicalAssetClassHierarchyScopeRelRelationship? left, PhysicalAssetClassHierarchyScopeRelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PhysicalAssetClassHierarchyScopeRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}