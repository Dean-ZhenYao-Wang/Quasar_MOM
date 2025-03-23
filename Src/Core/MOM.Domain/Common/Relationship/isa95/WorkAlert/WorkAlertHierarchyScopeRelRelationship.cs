namespace MOM.Domain.Common.Relationship.isa95.WorkAlert
{
    public class WorkAlertHierarchyScopeRelRelationship : Relationship<Domain.isa95.CommonObjectModels.HierarchyScope>, IEquatable<WorkAlertHierarchyScopeRelRelationship>
    {
        public WorkAlertHierarchyScopeRelRelationship()
        {
            Name = "hierarchyScopeRel";
        }

        public WorkAlertHierarchyScopeRelRelationship(MOM.Domain.isa95.CommonObjectModels.Part4.WorkAlert.WorkAlert source, Domain.isa95.CommonObjectModels.HierarchyScope target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkAlertHierarchyScopeRelRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkAlertHierarchyScopeRelRelationship);
        }

        public bool Equals(WorkAlertHierarchyScopeRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkAlertHierarchyScopeRelRelationship? left, WorkAlertHierarchyScopeRelRelationship? right)
        {
            return EqualityComparer<WorkAlertHierarchyScopeRelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkAlertHierarchyScopeRelRelationship? left, WorkAlertHierarchyScopeRelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkAlertHierarchyScopeRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}