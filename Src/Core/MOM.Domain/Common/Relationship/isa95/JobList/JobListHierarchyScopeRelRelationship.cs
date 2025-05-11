namespace MOM.Domain.Common.Relationship.isa95.JobList
{
    public class JobListHierarchyScopeRelRelationship : Relationship<Domain.isa95.CommonObjectModels.HierarchyScope>, IEquatable<JobListHierarchyScopeRelRelationship>
    {
        public JobListHierarchyScopeRelRelationship()
        {
            Name = "hierarchyScopeRel";
        }

        public JobListHierarchyScopeRelRelationship(Domain.isa95.CommonObjectModels.Part4.WorkSchedule.JobList source, Domain.isa95.CommonObjectModels.HierarchyScope target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public JobListHierarchyScopeRelRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as JobListHierarchyScopeRelRelationship);
        }

        public bool Equals(JobListHierarchyScopeRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(JobListHierarchyScopeRelRelationship? left, JobListHierarchyScopeRelRelationship? right)
        {
            return EqualityComparer<JobListHierarchyScopeRelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(JobListHierarchyScopeRelRelationship? left, JobListHierarchyScopeRelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as JobListHierarchyScopeRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}