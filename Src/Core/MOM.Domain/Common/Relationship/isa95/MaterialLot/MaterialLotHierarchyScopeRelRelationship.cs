namespace MOM.Domain.Common.Relationship.isa95.MaterialLot
{
    public class MaterialLotHierarchyScopeRelRelationship : Relationship<Domain.isa95.CommonObjectModels.HierarchyScope>, IEquatable<MaterialLotHierarchyScopeRelRelationship>
    {
        public MaterialLotHierarchyScopeRelRelationship()
        {
            Name = "hierarchyScopeRel";
        }

        public MaterialLotHierarchyScopeRelRelationship(Domain.isa95.CommonObjectModels.Part2.Material.MaterialLot source, Domain.isa95.CommonObjectModels.HierarchyScope target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public MaterialLotHierarchyScopeRelRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialLotHierarchyScopeRelRelationship);
        }

        public bool Equals(MaterialLotHierarchyScopeRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(MaterialLotHierarchyScopeRelRelationship? left, MaterialLotHierarchyScopeRelRelationship? right)
        {
            return EqualityComparer<MaterialLotHierarchyScopeRelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialLotHierarchyScopeRelRelationship? left, MaterialLotHierarchyScopeRelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as MaterialLotHierarchyScopeRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}