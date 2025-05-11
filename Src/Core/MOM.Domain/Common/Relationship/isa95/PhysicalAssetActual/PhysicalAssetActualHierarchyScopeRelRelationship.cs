namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetActual
{
    public class PhysicalAssetActualHierarchyScopeRelRelationship : Relationship<Domain.isa95.CommonObjectModels.HierarchyScope>, IEquatable<PhysicalAssetActualHierarchyScopeRelRelationship>
    {
        public PhysicalAssetActualHierarchyScopeRelRelationship()
        {
            Name = "hierarchyScopeRel";
        }

        public PhysicalAssetActualHierarchyScopeRelRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.PhysicalAssetActual source, Domain.isa95.CommonObjectModels.HierarchyScope target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PhysicalAssetActualHierarchyScopeRelRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PhysicalAssetActualHierarchyScopeRelRelationship);
        }

        public bool Equals(PhysicalAssetActualHierarchyScopeRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PhysicalAssetActualHierarchyScopeRelRelationship? left, PhysicalAssetActualHierarchyScopeRelRelationship? right)
        {
            return EqualityComparer<PhysicalAssetActualHierarchyScopeRelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PhysicalAssetActualHierarchyScopeRelRelationship? left, PhysicalAssetActualHierarchyScopeRelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PhysicalAssetActualHierarchyScopeRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}