namespace MOM.Domain.Common.Relationship.isa95.EquipmentAssetMapping
{
    public class EquipmentAssetMappingHierarchyScopeRelRelationship : Relationship<Domain.isa95.CommonObjectModels.HierarchyScope>, IEquatable<EquipmentAssetMappingHierarchyScopeRelRelationship>
    {
        public EquipmentAssetMappingHierarchyScopeRelRelationship()
        {
            Name = "hierarchyScopeRel";
        }

        public EquipmentAssetMappingHierarchyScopeRelRelationship(Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentAssetMapping source, Domain.isa95.CommonObjectModels.HierarchyScope target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public EquipmentAssetMappingHierarchyScopeRelRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentAssetMappingHierarchyScopeRelRelationship);
        }

        public bool Equals(EquipmentAssetMappingHierarchyScopeRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(EquipmentAssetMappingHierarchyScopeRelRelationship? left, EquipmentAssetMappingHierarchyScopeRelRelationship? right)
        {
            return EqualityComparer<EquipmentAssetMappingHierarchyScopeRelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(EquipmentAssetMappingHierarchyScopeRelRelationship? left, EquipmentAssetMappingHierarchyScopeRelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as EquipmentAssetMappingHierarchyScopeRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}