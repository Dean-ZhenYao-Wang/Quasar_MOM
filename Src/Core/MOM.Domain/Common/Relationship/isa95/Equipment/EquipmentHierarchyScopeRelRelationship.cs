namespace MOM.Domain.Common.Relationship.isa95.Equipment
{
    /// <summary>
    /// 
    /// </summary>
    public class EquipmentHierarchyScopeRelRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.Equipment, Domain.isa95.CommonObjectModels.HierarchyScope>, IEquatable<EquipmentHierarchyScopeRelRelationship>
    {
        /// <inheritdoc/>
        public override string Name { get; set; } = "hierarchyScopeRel";
        /// <inheritdoc/>
        public EquipmentHierarchyScopeRelRelationship(Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.Equipment source, Domain.isa95.CommonObjectModels.HierarchyScope target) : base(source, target)
        {
        }
        /// <inheritdoc/>
        public EquipmentHierarchyScopeRelRelationship(Guid sourceId, Guid targetId) : base(sourceId, targetId)
        {
        }
        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentHierarchyScopeRelRelationship);
        }
        /// <inheritdoc/>
        public bool Equals(EquipmentHierarchyScopeRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }
        /// <inheritdoc/>
        public static bool operator ==(EquipmentHierarchyScopeRelRelationship? left, EquipmentHierarchyScopeRelRelationship? right)
        {
            return EqualityComparer<EquipmentHierarchyScopeRelRelationship?>.Default.Equals(left, right);
        }
        /// <inheritdoc/>
        public static bool operator !=(EquipmentHierarchyScopeRelRelationship? left, EquipmentHierarchyScopeRelRelationship? right)
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
            return Equals(other as EquipmentHierarchyScopeRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}