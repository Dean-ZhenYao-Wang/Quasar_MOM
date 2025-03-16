namespace MOM.Domain.Common.Relationship.isa95.WorkflowSpecificationConnectionProperty
{
    public class WorkflowSpecificationConnectionPropertyContainsRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationConnectionProperty>, IEquatable<WorkflowSpecificationConnectionPropertyContainsRelationship>
    {
        public WorkflowSpecificationConnectionPropertyContainsRelationship()
        {
            Name = "contains";
        }

        public WorkflowSpecificationConnectionPropertyContainsRelationship(Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationConnectionProperty source, Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationConnectionProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkflowSpecificationConnectionPropertyContainsRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkflowSpecificationConnectionPropertyContainsRelationship);
        }

        public bool Equals(WorkflowSpecificationConnectionPropertyContainsRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkflowSpecificationConnectionPropertyContainsRelationship? left, WorkflowSpecificationConnectionPropertyContainsRelationship? right)
        {
            return EqualityComparer<WorkflowSpecificationConnectionPropertyContainsRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkflowSpecificationConnectionPropertyContainsRelationship? left, WorkflowSpecificationConnectionPropertyContainsRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkflowSpecificationConnectionPropertyContainsRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}