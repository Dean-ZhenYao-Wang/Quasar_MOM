namespace MOM.Domain.Common.Relationship.isa95.WorkflowSpecificationNode
{
    public class WorkflowSpecificationNodeContainsRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecification>, IEquatable<WorkflowSpecificationNodeContainsRelationship>
    {
        public WorkflowSpecificationNodeContainsRelationship()
        {
            Name = "contains";
        }

        public WorkflowSpecificationNodeContainsRelationship(Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationNode source, Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecification target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkflowSpecificationNodeContainsRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkflowSpecificationNodeContainsRelationship);
        }

        public bool Equals(WorkflowSpecificationNodeContainsRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkflowSpecificationNodeContainsRelationship? left, WorkflowSpecificationNodeContainsRelationship? right)
        {
            return EqualityComparer<WorkflowSpecificationNodeContainsRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkflowSpecificationNodeContainsRelationship? left, WorkflowSpecificationNodeContainsRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkflowSpecificationNodeContainsRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}