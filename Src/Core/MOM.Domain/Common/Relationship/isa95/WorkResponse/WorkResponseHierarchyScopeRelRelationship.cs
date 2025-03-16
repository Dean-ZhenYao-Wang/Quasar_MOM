namespace MOM.Domain.Common.Relationship.isa95.WorkResponse
{
    public class WorkResponseHierarchyScopeRelRelationship : Relationship<Domain.isa95.CommonObjectModels.HierarchyScope>, IEquatable<WorkResponseHierarchyScopeRelRelationship>
    {
        public WorkResponseHierarchyScopeRelRelationship()
        {
            Name = "hierarchyScopeRel";
        }

        public WorkResponseHierarchyScopeRelRelationship(Domain.isa95.CommonObjectModels.Part4.WorkPerformance.WorkResponse source, Domain.isa95.CommonObjectModels.HierarchyScope target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkResponseHierarchyScopeRelRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkResponseHierarchyScopeRelRelationship);
        }

        public bool Equals(WorkResponseHierarchyScopeRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkResponseHierarchyScopeRelRelationship? left, WorkResponseHierarchyScopeRelRelationship? right)
        {
            return EqualityComparer<WorkResponseHierarchyScopeRelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkResponseHierarchyScopeRelRelationship? left, WorkResponseHierarchyScopeRelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkResponseHierarchyScopeRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}