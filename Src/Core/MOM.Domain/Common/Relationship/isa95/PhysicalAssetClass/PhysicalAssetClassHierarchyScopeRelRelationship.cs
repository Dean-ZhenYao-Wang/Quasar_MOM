

namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetClass
{
    /// <summary>
    /// 
    /// </summary>
    public class PhysicalAssetClassHierarchyScopeRelRelationship : Relationship<MOM.Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAssetClass, Domain.isa95.CommonObjectModels.HierarchyScope>, IEquatable<PhysicalAssetClassHierarchyScopeRelRelationship>
    {
        /// <inheritdoc/>
        public override string Name { get; set; } = "hierarchyScopeRel";
        /// <inheritdoc/>
        public PhysicalAssetClassHierarchyScopeRelRelationship(Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAssetClass source, Domain.isa95.CommonObjectModels.HierarchyScope target) : base(source, target)
        {
        }
        /// <inheritdoc/>
        public PhysicalAssetClassHierarchyScopeRelRelationship(Guid sourceId, Guid targetId) : base(sourceId, targetId)
        {
        }
        /// <inheritdoc/>
        public PhysicalAssetClassHierarchyScopeRelRelationship(Guid sourceId, Guid targetId, int depth) : base(sourceId, targetId, depth)
        {
        }
        /// <inheritdoc/>
        public PhysicalAssetClassHierarchyScopeRelRelationship(Guid sourceId, Domain.isa95.CommonObjectModels.HierarchyScope target, int depth) : base(sourceId, target, depth)
        {
        }

        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            return Equals(obj as PhysicalAssetClassHierarchyScopeRelRelationship);
        }

        /// <inheritdoc/>
        public bool Equals(PhysicalAssetClassHierarchyScopeRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        /// <inheritdoc/>
        public static bool operator ==(PhysicalAssetClassHierarchyScopeRelRelationship? left, PhysicalAssetClassHierarchyScopeRelRelationship? right)
        {
            return EqualityComparer<PhysicalAssetClassHierarchyScopeRelRelationship?>.Default.Equals(left, right);
        }

        /// <inheritdoc/>
        public static bool operator !=(PhysicalAssetClassHierarchyScopeRelRelationship? left, PhysicalAssetClassHierarchyScopeRelRelationship? right)
        {
            return !(left == right);
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        /// <inheritdoc/>
        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PhysicalAssetClassHierarchyScopeRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}