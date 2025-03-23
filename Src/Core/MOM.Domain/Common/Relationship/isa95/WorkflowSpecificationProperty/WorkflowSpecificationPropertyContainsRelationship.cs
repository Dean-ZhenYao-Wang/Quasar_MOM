namespace MOM.Domain.Common.Relationship.isa95.WorkflowSpecificationProperty
{
    public class WorkflowSpecificationPropertyContainsRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationProperty>, IEquatable<WorkflowSpecificationPropertyContainsRelationship>
    {
        public WorkflowSpecificationPropertyContainsRelationship()
        {
            Name = "contains";
        }

        public WorkflowSpecificationPropertyContainsRelationship(Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationProperty source, Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkflowSpecificationPropertyContainsRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkflowSpecificationPropertyContainsRelationship);
        }

        public bool Equals(WorkflowSpecificationPropertyContainsRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkflowSpecificationPropertyContainsRelationship? left, WorkflowSpecificationPropertyContainsRelationship? right)
        {
            return EqualityComparer<WorkflowSpecificationPropertyContainsRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkflowSpecificationPropertyContainsRelationship? left, WorkflowSpecificationPropertyContainsRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkflowSpecificationPropertyContainsRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}