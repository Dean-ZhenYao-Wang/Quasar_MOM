namespace MOM.Domain.Common.Relationship.isa95.JobResponse
{
    public class JobResponseHierarchyScopeRelRelationship : Relationship<Domain.isa95.CommonObjectModels.HierarchyScope>, IEquatable<JobResponseHierarchyScopeRelRelationship>
    {
        public JobResponseHierarchyScopeRelRelationship()
        {
            Name = "hierarchyScopeRel";
        }

        public JobResponseHierarchyScopeRelRelationship(Domain.isa95.CommonObjectModels.Part4.WorkPerformance.JobResponse source, Domain.isa95.CommonObjectModels.HierarchyScope target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public JobResponseHierarchyScopeRelRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as JobResponseHierarchyScopeRelRelationship);
        }

        public bool Equals(JobResponseHierarchyScopeRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(JobResponseHierarchyScopeRelRelationship? left, JobResponseHierarchyScopeRelRelationship? right)
        {
            return EqualityComparer<JobResponseHierarchyScopeRelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(JobResponseHierarchyScopeRelRelationship? left, JobResponseHierarchyScopeRelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as JobResponseHierarchyScopeRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}