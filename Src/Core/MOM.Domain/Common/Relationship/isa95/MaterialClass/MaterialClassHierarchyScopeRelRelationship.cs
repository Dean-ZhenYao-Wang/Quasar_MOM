namespace MOM.Domain.Common.Relationship.isa95.MaterialClass
{
    public class MaterialClassHierarchyScopeRelRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.Material.MaterialClass ,Domain.isa95.CommonObjectModels.HierarchyScope>, IEquatable<MaterialClassHierarchyScopeRelRelationship>
    {
        public MaterialClassHierarchyScopeRelRelationship() : base()
        {
            Name = "hierarchyScopeRel";
        }
        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialClassHierarchyScopeRelRelationship);
        }

        public bool Equals(MaterialClassHierarchyScopeRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(MaterialClassHierarchyScopeRelRelationship? left, MaterialClassHierarchyScopeRelRelationship? right)
        {
            return EqualityComparer<MaterialClassHierarchyScopeRelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialClassHierarchyScopeRelRelationship? left, MaterialClassHierarchyScopeRelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as MaterialClassHierarchyScopeRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}