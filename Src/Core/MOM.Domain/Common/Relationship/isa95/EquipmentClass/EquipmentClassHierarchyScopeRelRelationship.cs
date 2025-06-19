
namespace MOM.Domain.Common.Relationship.isa95.EquipmentClass
{
    public class EquipmentClassHierarchyScopeRelRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentClass,Domain.isa95.CommonObjectModels.HierarchyScope>, IEquatable<EquipmentClassHierarchyScopeRelRelationship>
    {
        public EquipmentClassHierarchyScopeRelRelationship()
        {
            Name = "hierarchyScopeRel";
        }

        public EquipmentClassHierarchyScopeRelRelationship(Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentClass source, Domain.isa95.CommonObjectModels.HierarchyScope target) : base(source, target)
        {
        }

        public EquipmentClassHierarchyScopeRelRelationship(Guid sourceId, Guid targetId) : base(sourceId, targetId)
        {
        }

        public EquipmentClassHierarchyScopeRelRelationship(Guid sourceId, Guid targetId, int depth) : base(sourceId, targetId, depth)
        {
        }

        public EquipmentClassHierarchyScopeRelRelationship(Guid sourceId, Domain.isa95.CommonObjectModels.HierarchyScope target, int depth) : base(sourceId, target, depth)
        {
        }


        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentClassHierarchyScopeRelRelationship);
        }

        /// <inheritdoc/>
        public bool Equals(EquipmentClassHierarchyScopeRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        /// <inheritdoc/>
        public static bool operator ==(EquipmentClassHierarchyScopeRelRelationship? left, EquipmentClassHierarchyScopeRelRelationship? right)
        {
            return EqualityComparer<EquipmentClassHierarchyScopeRelRelationship?>.Default.Equals(left, right);
        }

        /// <inheritdoc/>
        public static bool operator !=(EquipmentClassHierarchyScopeRelRelationship? left, EquipmentClassHierarchyScopeRelRelationship? right)
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
            return Equals(other as EquipmentClassHierarchyScopeRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}