namespace MOM.Domain.Common.Relationship.isa95.WorkflowSpecificationNode
{
    public class WorkflowSpecificationNodeCorrespondsToWorkDirectiveRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.WorkDefinition.WorkDirective>, IEquatable<WorkflowSpecificationNodeCorrespondsToWorkDirectiveRelationship>
    {
        public WorkflowSpecificationNodeCorrespondsToWorkDirectiveRelationship()
        {
            Name = "correspondsToWorkDirective";
        }

        public WorkflowSpecificationNodeCorrespondsToWorkDirectiveRelationship(Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationNode source, Domain.isa95.CommonObjectModels.Part4.WorkDefinition.WorkDirective target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkflowSpecificationNodeCorrespondsToWorkDirectiveRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkflowSpecificationNodeCorrespondsToWorkDirectiveRelationship);
        }

        public bool Equals(WorkflowSpecificationNodeCorrespondsToWorkDirectiveRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkflowSpecificationNodeCorrespondsToWorkDirectiveRelationship? left, WorkflowSpecificationNodeCorrespondsToWorkDirectiveRelationship? right)
        {
            return EqualityComparer<WorkflowSpecificationNodeCorrespondsToWorkDirectiveRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkflowSpecificationNodeCorrespondsToWorkDirectiveRelationship? left, WorkflowSpecificationNodeCorrespondsToWorkDirectiveRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkflowSpecificationNodeCorrespondsToWorkDirectiveRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}