namespace MOM.Domain.Common.Relationship.isa95.WorkRequest
{
    public class WorkRequestHierarchyScopeRelRelationship : Relationship<Domain.isa95.CommonObjectModels.HierarchyScope>, IEquatable<WorkRequestHierarchyScopeRelRelationship>
    {
        public WorkRequestHierarchyScopeRelRelationship()
        {
            Name = "hierarchyScopeRel";
        }

        public WorkRequestHierarchyScopeRelRelationship(Domain.isa95.CommonObjectModels.Part4.WorkSchedule.WorkRequest source, Domain.isa95.CommonObjectModels.HierarchyScope target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkRequestHierarchyScopeRelRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkRequestHierarchyScopeRelRelationship);
        }

        public bool Equals(WorkRequestHierarchyScopeRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkRequestHierarchyScopeRelRelationship? left, WorkRequestHierarchyScopeRelRelationship? right)
        {
            return EqualityComparer<WorkRequestHierarchyScopeRelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkRequestHierarchyScopeRelRelationship? left, WorkRequestHierarchyScopeRelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkRequestHierarchyScopeRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}