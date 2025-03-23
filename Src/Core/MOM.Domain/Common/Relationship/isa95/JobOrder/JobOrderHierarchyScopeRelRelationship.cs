namespace MOM.Domain.Common.Relationship.isa95.JobOrder
{
    public class JobOrderHierarchyScopeRelRelationship : Relationship<Domain.isa95.CommonObjectModels.HierarchyScope>, IEquatable<JobOrderHierarchyScopeRelRelationship>
    {
        public JobOrderHierarchyScopeRelRelationship()
        {
            Name = "hierarchyScopeRel";
        }

        public JobOrderHierarchyScopeRelRelationship(Domain.isa95.CommonObjectModels.Part4.WorkSchedule.JobOrder source, Domain.isa95.CommonObjectModels.HierarchyScope target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public JobOrderHierarchyScopeRelRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as JobOrderHierarchyScopeRelRelationship);
        }

        public bool Equals(JobOrderHierarchyScopeRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(JobOrderHierarchyScopeRelRelationship? left, JobOrderHierarchyScopeRelRelationship? right)
        {
            return EqualityComparer<JobOrderHierarchyScopeRelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(JobOrderHierarchyScopeRelRelationship? left, JobOrderHierarchyScopeRelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as JobOrderHierarchyScopeRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}