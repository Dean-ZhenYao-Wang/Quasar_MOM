namespace MOM.Domain.Common.Relationship.isa95.WorkflowSpecificationNode
{
    public class WorkflowSpecificationNodeDefinedByRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationNodeType>, IEquatable<WorkflowSpecificationNodeDefinedByRelationship>
    {
        public WorkflowSpecificationNodeDefinedByRelationship()
        {
            Name = "definedBy";
        }

        public WorkflowSpecificationNodeDefinedByRelationship(Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationNode source, Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationNodeType target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkflowSpecificationNodeDefinedByRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkflowSpecificationNodeDefinedByRelationship);
        }

        public bool Equals(WorkflowSpecificationNodeDefinedByRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkflowSpecificationNodeDefinedByRelationship? left, WorkflowSpecificationNodeDefinedByRelationship? right)
        {
            return EqualityComparer<WorkflowSpecificationNodeDefinedByRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkflowSpecificationNodeDefinedByRelationship? left, WorkflowSpecificationNodeDefinedByRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkflowSpecificationNodeDefinedByRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}