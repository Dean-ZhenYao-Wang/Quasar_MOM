namespace MOM.Domain.Common.Relationship.isa95.WorkDefinition
{
    public class WorkDefinitionHierarchyScopeRelRelationship : Relationship<Domain.isa95.CommonObjectModels.HierarchyScope>, IEquatable<WorkDefinitionHierarchyScopeRelRelationship>
    {
        public WorkDefinitionHierarchyScopeRelRelationship()
        {
            Name = "hierarchyScopeRel";
        }

        public WorkDefinitionHierarchyScopeRelRelationship(Domain.isa95.CommonObjectModels.Part4.WorkDefinition.WorkDefinition source, Domain.isa95.CommonObjectModels.HierarchyScope target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkDefinitionHierarchyScopeRelRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkDefinitionHierarchyScopeRelRelationship);
        }

        public bool Equals(WorkDefinitionHierarchyScopeRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkDefinitionHierarchyScopeRelRelationship? left, WorkDefinitionHierarchyScopeRelRelationship? right)
        {
            return EqualityComparer<WorkDefinitionHierarchyScopeRelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkDefinitionHierarchyScopeRelRelationship? left, WorkDefinitionHierarchyScopeRelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkDefinitionHierarchyScopeRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}