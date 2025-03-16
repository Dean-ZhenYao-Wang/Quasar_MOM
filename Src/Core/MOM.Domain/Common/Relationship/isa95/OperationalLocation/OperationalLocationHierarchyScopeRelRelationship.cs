namespace MOM.Domain.Common.Relationship.isa95.OperationalLocation
{
    public class OperationalLocationHierarchyScopeRelRelationship : Relationship<Domain.isa95.CommonObjectModels.HierarchyScope>, IEquatable<OperationalLocationHierarchyScopeRelRelationship>
    {
        public OperationalLocationHierarchyScopeRelRelationship()
        {
            Name = "hierarchyScopeRel";
        }

        public OperationalLocationHierarchyScopeRelRelationship(Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation source, Domain.isa95.CommonObjectModels.HierarchyScope target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationalLocationHierarchyScopeRelRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationalLocationHierarchyScopeRelRelationship);
        }

        public bool Equals(OperationalLocationHierarchyScopeRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationalLocationHierarchyScopeRelRelationship? left, OperationalLocationHierarchyScopeRelRelationship? right)
        {
            return EqualityComparer<OperationalLocationHierarchyScopeRelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationalLocationHierarchyScopeRelRelationship? left, OperationalLocationHierarchyScopeRelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationalLocationHierarchyScopeRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}