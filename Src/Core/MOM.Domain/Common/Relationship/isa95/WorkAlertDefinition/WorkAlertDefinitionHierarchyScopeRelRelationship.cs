namespace MOM.Domain.Common.Relationship.isa95.WorkAlertDefinition
{
    public class WorkAlertDefinitionHierarchyScopeRelRelationship : Relationship<Domain.isa95.CommonObjectModels.HierarchyScope>, IEquatable<WorkAlertDefinitionHierarchyScopeRelRelationship>
    {
        public WorkAlertDefinitionHierarchyScopeRelRelationship()
        {
            Name = "hierarchyScopeRel";
        }

        public WorkAlertDefinitionHierarchyScopeRelRelationship(Domain.isa95.CommonObjectModels.Part4.WorkAlert.WorkAlertDefinition source, Domain.isa95.CommonObjectModels.HierarchyScope target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkAlertDefinitionHierarchyScopeRelRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkAlertDefinitionHierarchyScopeRelRelationship);
        }

        public bool Equals(WorkAlertDefinitionHierarchyScopeRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkAlertDefinitionHierarchyScopeRelRelationship? left, WorkAlertDefinitionHierarchyScopeRelRelationship? right)
        {
            return EqualityComparer<WorkAlertDefinitionHierarchyScopeRelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkAlertDefinitionHierarchyScopeRelRelationship? left, WorkAlertDefinitionHierarchyScopeRelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkAlertDefinitionHierarchyScopeRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}