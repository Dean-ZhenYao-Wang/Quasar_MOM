namespace MOM.Domain.Common.Relationship.isa95.WorkSchedule
{
    public class WorkScheduleHierarchyScopeRelRelationship : Relationship<Domain.isa95.CommonObjectModels.HierarchyScope>, IEquatable<WorkScheduleHierarchyScopeRelRelationship>
    {
        public WorkScheduleHierarchyScopeRelRelationship()
        {
            Name = "hierarchyScopeRel";
        }

        public WorkScheduleHierarchyScopeRelRelationship(Domain.isa95.CommonObjectModels.Part4.WorkSchedule.WorkSchedule source, Domain.isa95.CommonObjectModels.HierarchyScope target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkScheduleHierarchyScopeRelRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkScheduleHierarchyScopeRelRelationship);
        }

        public bool Equals(WorkScheduleHierarchyScopeRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkScheduleHierarchyScopeRelRelationship? left, WorkScheduleHierarchyScopeRelRelationship? right)
        {
            return EqualityComparer<WorkScheduleHierarchyScopeRelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkScheduleHierarchyScopeRelRelationship? left, WorkScheduleHierarchyScopeRelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkScheduleHierarchyScopeRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}