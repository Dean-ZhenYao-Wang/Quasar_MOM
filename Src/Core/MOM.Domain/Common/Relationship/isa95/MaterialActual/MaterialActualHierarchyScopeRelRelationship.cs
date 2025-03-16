namespace MOM.Domain.Common.Relationship.isa95.MaterialActual
{
    public class MaterialActualHierarchyScopeRelRelationship : Relationship<Domain.isa95.CommonObjectModels.HierarchyScope>, IEquatable<MaterialActualHierarchyScopeRelRelationship>
    {
        public MaterialActualHierarchyScopeRelRelationship()
        {
            Name = "hierarchyScopeRel";
        }

        public MaterialActualHierarchyScopeRelRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.MaterialActual source, Domain.isa95.CommonObjectModels.HierarchyScope target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public MaterialActualHierarchyScopeRelRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialActualHierarchyScopeRelRelationship);
        }

        public bool Equals(MaterialActualHierarchyScopeRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(MaterialActualHierarchyScopeRelRelationship? left, MaterialActualHierarchyScopeRelRelationship? right)
        {
            return EqualityComparer<MaterialActualHierarchyScopeRelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialActualHierarchyScopeRelRelationship? left, MaterialActualHierarchyScopeRelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as MaterialActualHierarchyScopeRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}