namespace MOM.Domain.Common.Relationship.isa95.JobResponseData
{
    public class JobResponseDataHierarchyScopeRelRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.WorkPerformance.JobResponseData ,Domain.isa95.CommonObjectModels.HierarchyScope>, IEquatable<JobResponseDataHierarchyScopeRelRelationship>
    {
        public JobResponseDataHierarchyScopeRelRelationship()
        {
            Name = "hierarchyScopeRel";
        }

        public JobResponseDataHierarchyScopeRelRelationship(Domain.isa95.CommonObjectModels.Part4.WorkPerformance.JobResponseData source, Domain.isa95.CommonObjectModels.HierarchyScope target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public JobResponseDataHierarchyScopeRelRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as JobResponseDataHierarchyScopeRelRelationship);
        }

        public bool Equals(JobResponseDataHierarchyScopeRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(JobResponseDataHierarchyScopeRelRelationship? left, JobResponseDataHierarchyScopeRelRelationship? right)
        {
            return EqualityComparer<JobResponseDataHierarchyScopeRelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(JobResponseDataHierarchyScopeRelRelationship? left, JobResponseDataHierarchyScopeRelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as JobResponseDataHierarchyScopeRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}