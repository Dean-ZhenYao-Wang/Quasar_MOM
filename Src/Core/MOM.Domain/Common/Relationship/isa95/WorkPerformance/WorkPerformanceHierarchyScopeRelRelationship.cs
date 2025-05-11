namespace MOM.Domain.Common.Relationship.isa95.WorkPerformance
{
    public class WorkPerformanceHierarchyScopeRelRelationship : Relationship<Domain.isa95.CommonObjectModels.HierarchyScope>, IEquatable<WorkPerformanceHierarchyScopeRelRelationship>
    {
        public WorkPerformanceHierarchyScopeRelRelationship()
        {
            Name = "hierarchyScopeRel";
        }

        public WorkPerformanceHierarchyScopeRelRelationship(Domain.isa95.CommonObjectModels.Part4.WorkPerformance.WorkPerformance source, Domain.isa95.CommonObjectModels.HierarchyScope target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkPerformanceHierarchyScopeRelRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkPerformanceHierarchyScopeRelRelationship);
        }

        public bool Equals(WorkPerformanceHierarchyScopeRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkPerformanceHierarchyScopeRelRelationship? left, WorkPerformanceHierarchyScopeRelRelationship? right)
        {
            return EqualityComparer<WorkPerformanceHierarchyScopeRelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkPerformanceHierarchyScopeRelRelationship? left, WorkPerformanceHierarchyScopeRelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkPerformanceHierarchyScopeRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}