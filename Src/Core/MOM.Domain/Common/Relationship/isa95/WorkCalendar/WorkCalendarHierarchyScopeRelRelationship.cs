namespace MOM.Domain.Common.Relationship.isa95.WorkCalendar
{
    public class WorkCalendarHierarchyScopeRelRelationship : Relationship<Domain.isa95.CommonObjectModels.HierarchyScope>, IEquatable<WorkCalendarHierarchyScopeRelRelationship>
    {
        public WorkCalendarHierarchyScopeRelRelationship()
        {
            Name = "hierarchyScopeRel";
        }

        public WorkCalendarHierarchyScopeRelRelationship(Domain.isa95.CommonObjectModels.Part4.WorkCalendar.WorkCalendar source, Domain.isa95.CommonObjectModels.HierarchyScope target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkCalendarHierarchyScopeRelRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkCalendarHierarchyScopeRelRelationship);
        }

        public bool Equals(WorkCalendarHierarchyScopeRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkCalendarHierarchyScopeRelRelationship? left, WorkCalendarHierarchyScopeRelRelationship? right)
        {
            return EqualityComparer<WorkCalendarHierarchyScopeRelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkCalendarHierarchyScopeRelRelationship? left, WorkCalendarHierarchyScopeRelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkCalendarHierarchyScopeRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}