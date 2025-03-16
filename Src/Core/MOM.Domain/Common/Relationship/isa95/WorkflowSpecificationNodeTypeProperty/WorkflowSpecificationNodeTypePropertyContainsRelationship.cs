namespace MOM.Domain.Common.Relationship.isa95.WorkflowSpecificationNodeTypeProperty
{
    public class WorkflowSpecificationNodeTypePropertyContainsRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationNodeTypeProperty>, IEquatable<WorkflowSpecificationNodeTypePropertyContainsRelationship>
    {
        public WorkflowSpecificationNodeTypePropertyContainsRelationship()
        {
            Name = "contains";
        }

        public WorkflowSpecificationNodeTypePropertyContainsRelationship(Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationNodeTypeProperty source, Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationNodeTypeProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkflowSpecificationNodeTypePropertyContainsRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkflowSpecificationNodeTypePropertyContainsRelationship);
        }

        public bool Equals(WorkflowSpecificationNodeTypePropertyContainsRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkflowSpecificationNodeTypePropertyContainsRelationship? left, WorkflowSpecificationNodeTypePropertyContainsRelationship? right)
        {
            return EqualityComparer<WorkflowSpecificationNodeTypePropertyContainsRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkflowSpecificationNodeTypePropertyContainsRelationship? left, WorkflowSpecificationNodeTypePropertyContainsRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkflowSpecificationNodeTypePropertyContainsRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}