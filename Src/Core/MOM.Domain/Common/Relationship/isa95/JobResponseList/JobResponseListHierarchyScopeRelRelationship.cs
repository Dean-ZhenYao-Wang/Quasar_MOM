namespace MOM.Domain.Common.Relationship.isa95.JobResponseList
{
    public class JobResponseListHierarchyScopeRelRelationship : Relationship<Domain.isa95.CommonObjectModels.HierarchyScope>, IEquatable<JobResponseListHierarchyScopeRelRelationship>
    {
        public JobResponseListHierarchyScopeRelRelationship()
        {
            Name = "hierarchyScopeRel";
        }

        public JobResponseListHierarchyScopeRelRelationship(Domain.isa95.CommonObjectModels.Part4.WorkPerformance.JobResponseList source, Domain.isa95.CommonObjectModels.HierarchyScope target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public JobResponseListHierarchyScopeRelRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as JobResponseListHierarchyScopeRelRelationship);
        }

        public bool Equals(JobResponseListHierarchyScopeRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(JobResponseListHierarchyScopeRelRelationship? left, JobResponseListHierarchyScopeRelRelationship? right)
        {
            return EqualityComparer<JobResponseListHierarchyScopeRelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(JobResponseListHierarchyScopeRelRelationship? left, JobResponseListHierarchyScopeRelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as JobResponseListHierarchyScopeRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}