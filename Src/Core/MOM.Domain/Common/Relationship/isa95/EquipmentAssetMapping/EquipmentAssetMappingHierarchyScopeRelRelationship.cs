
namespace MOM.Domain.Common.Relationship.isa95.EquipmentAssetMapping
{
    /// <summary>
    /// 
    /// </summary>
    public class EquipmentAssetMappingHierarchyScopeRelRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentAssetMapping,Domain.isa95.CommonObjectModels.HierarchyScope>, IEquatable<EquipmentAssetMappingHierarchyScopeRelRelationship>
    {
        /// <inheritdoc/>
        public override string Name { get; set; } = "hierarchyScopeRel";
        /// <inheritdoc/>
        public EquipmentAssetMappingHierarchyScopeRelRelationship(Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentAssetMapping source, Domain.isa95.CommonObjectModels.HierarchyScope target) : base(source, target)
        {
        }
        /// <inheritdoc/>
        public EquipmentAssetMappingHierarchyScopeRelRelationship(Guid sourceId, Guid targetId) : base(sourceId, targetId)
        {
        }
        /// <inheritdoc/>
        public EquipmentAssetMappingHierarchyScopeRelRelationship(Guid sourceId, Guid targetId, int depth) : base(sourceId, targetId, depth)
        {
        }
        /// <inheritdoc/>
        public EquipmentAssetMappingHierarchyScopeRelRelationship(Guid sourceId, Domain.isa95.CommonObjectModels.HierarchyScope target, int depth) : base(sourceId, target, depth)
        {
        }

        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentAssetMappingHierarchyScopeRelRelationship);
        }

        /// <inheritdoc/>
        public bool Equals(EquipmentAssetMappingHierarchyScopeRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        /// <inheritdoc/>
        public static bool operator ==(EquipmentAssetMappingHierarchyScopeRelRelationship? left, EquipmentAssetMappingHierarchyScopeRelRelationship? right)
        {
            return EqualityComparer<EquipmentAssetMappingHierarchyScopeRelRelationship?>.Default.Equals(left, right);
        }

        /// <inheritdoc/>
        public static bool operator !=(EquipmentAssetMappingHierarchyScopeRelRelationship? left, EquipmentAssetMappingHierarchyScopeRelRelationship? right)
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
            return Equals(other as EquipmentAssetMappingHierarchyScopeRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}