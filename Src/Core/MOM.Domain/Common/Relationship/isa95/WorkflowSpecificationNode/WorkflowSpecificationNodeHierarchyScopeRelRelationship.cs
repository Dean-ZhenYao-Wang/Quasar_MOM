namespace MOM.Domain.Common.Relationship.isa95.WorkflowSpecificationNode
{
    public class WorkflowSpecificationNodeHierarchyScopeRelRelationship : Relationship<Domain.isa95.CommonObjectModels.HierarchyScope>, IEquatable<WorkflowSpecificationNodeHierarchyScopeRelRelationship>
    {
        public WorkflowSpecificationNodeHierarchyScopeRelRelationship()
        {
            Name = "hierarchyScopeRel";
        }

        public WorkflowSpecificationNodeHierarchyScopeRelRelationship(Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationNode source, Domain.isa95.CommonObjectModels.HierarchyScope target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkflowSpecificationNodeHierarchyScopeRelRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkflowSpecificationNodeHierarchyScopeRelRelationship);
        }

        public bool Equals(WorkflowSpecificationNodeHierarchyScopeRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkflowSpecificationNodeHierarchyScopeRelRelationship? left, WorkflowSpecificationNodeHierarchyScopeRelRelationship? right)
        {
            return EqualityComparer<WorkflowSpecificationNodeHierarchyScopeRelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkflowSpecificationNodeHierarchyScopeRelRelationship? left, WorkflowSpecificationNodeHierarchyScopeRelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkflowSpecificationNodeHierarchyScopeRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}