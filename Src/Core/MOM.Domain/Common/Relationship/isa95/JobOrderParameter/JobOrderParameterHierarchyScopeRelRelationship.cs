namespace MOM.Domain.Common.Relationship.isa95.JobOrderParameter
{
    public class JobOrderParameterHierarchyScopeRelRelationship : Relationship<Domain.isa95.CommonObjectModels.HierarchyScope>, IEquatable<JobOrderParameterHierarchyScopeRelRelationship>
    {
        public JobOrderParameterHierarchyScopeRelRelationship()
        {
            Name = "hierarchyScopeRel";
        }

        public JobOrderParameterHierarchyScopeRelRelationship(Domain.isa95.CommonObjectModels.Part4.WorkSchedule.JobOrderParameter source, Domain.isa95.CommonObjectModels.HierarchyScope target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public JobOrderParameterHierarchyScopeRelRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as JobOrderParameterHierarchyScopeRelRelationship);
        }

        public bool Equals(JobOrderParameterHierarchyScopeRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(JobOrderParameterHierarchyScopeRelRelationship? left, JobOrderParameterHierarchyScopeRelRelationship? right)
        {
            return EqualityComparer<JobOrderParameterHierarchyScopeRelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(JobOrderParameterHierarchyScopeRelRelationship? left, JobOrderParameterHierarchyScopeRelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as JobOrderParameterHierarchyScopeRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}