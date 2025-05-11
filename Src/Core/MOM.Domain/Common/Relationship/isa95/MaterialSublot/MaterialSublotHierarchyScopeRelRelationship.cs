namespace MOM.Domain.Common.Relationship.isa95.MaterialSublot
{
    public class MaterialSublotHierarchyScopeRelRelationship : Relationship<Domain.isa95.CommonObjectModels.HierarchyScope>, IEquatable<MaterialSublotHierarchyScopeRelRelationship>
    {
        public MaterialSublotHierarchyScopeRelRelationship()
        {
            Name = "hierarchyScopeRel";
        }

        public MaterialSublotHierarchyScopeRelRelationship(Domain.isa95.CommonObjectModels.Part2.Material.MaterialSublot source, Domain.isa95.CommonObjectModels.HierarchyScope target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public MaterialSublotHierarchyScopeRelRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialSublotHierarchyScopeRelRelationship);
        }

        public bool Equals(MaterialSublotHierarchyScopeRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(MaterialSublotHierarchyScopeRelRelationship? left, MaterialSublotHierarchyScopeRelRelationship? right)
        {
            return EqualityComparer<MaterialSublotHierarchyScopeRelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialSublotHierarchyScopeRelRelationship? left, MaterialSublotHierarchyScopeRelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as MaterialSublotHierarchyScopeRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}