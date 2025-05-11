namespace MOM.Domain.Common.Relationship.isa95.OperationalLocationClass
{
    public class OperationalLocationClassHierarchyScopeRelRelationship : Relationship<Domain.isa95.CommonObjectModels.HierarchyScope>, IEquatable<OperationalLocationClassHierarchyScopeRelRelationship>
    {
        public OperationalLocationClassHierarchyScopeRelRelationship()
        {
            Name = "hierarchyScopeRel";
        }

        public OperationalLocationClassHierarchyScopeRelRelationship(Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocationClass source, Domain.isa95.CommonObjectModels.HierarchyScope target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationalLocationClassHierarchyScopeRelRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationalLocationClassHierarchyScopeRelRelationship);
        }

        public bool Equals(OperationalLocationClassHierarchyScopeRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationalLocationClassHierarchyScopeRelRelationship? left, OperationalLocationClassHierarchyScopeRelRelationship? right)
        {
            return EqualityComparer<OperationalLocationClassHierarchyScopeRelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationalLocationClassHierarchyScopeRelRelationship? left, OperationalLocationClassHierarchyScopeRelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationalLocationClassHierarchyScopeRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}