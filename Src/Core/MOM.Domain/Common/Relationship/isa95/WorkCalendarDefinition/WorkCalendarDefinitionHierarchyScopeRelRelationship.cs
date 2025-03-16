namespace MOM.Domain.Common.Relationship.isa95.WorkCalendarDefinition
{
    public class WorkCalendarDefinitionHierarchyScopeRelRelationship : Relationship<Domain.isa95.CommonObjectModels.HierarchyScope>, IEquatable<WorkCalendarDefinitionHierarchyScopeRelRelationship>
    {
        public WorkCalendarDefinitionHierarchyScopeRelRelationship()
        {
            Name = "hierarchyScopeRel";
        }

        public WorkCalendarDefinitionHierarchyScopeRelRelationship(Domain.isa95.CommonObjectModels.Part4.WorkCalendar.WorkCalendarDefinition source, Domain.isa95.CommonObjectModels.HierarchyScope target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkCalendarDefinitionHierarchyScopeRelRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkCalendarDefinitionHierarchyScopeRelRelationship);
        }

        public bool Equals(WorkCalendarDefinitionHierarchyScopeRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkCalendarDefinitionHierarchyScopeRelRelationship? left, WorkCalendarDefinitionHierarchyScopeRelRelationship? right)
        {
            return EqualityComparer<WorkCalendarDefinitionHierarchyScopeRelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkCalendarDefinitionHierarchyScopeRelRelationship? left, WorkCalendarDefinitionHierarchyScopeRelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkCalendarDefinitionHierarchyScopeRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}