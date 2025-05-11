namespace MOM.Domain.Common.Relationship.isa95.WorkflowSpecificationNodeProperty
{
    public class WorkflowSpecificationNodePropertyContainsRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationNodeProperty>, IEquatable<WorkflowSpecificationNodePropertyContainsRelationship>
    {
        public WorkflowSpecificationNodePropertyContainsRelationship()
        {
            Name = "contains";
        }

        public WorkflowSpecificationNodePropertyContainsRelationship(Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationNodeProperty source, Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationNodeProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkflowSpecificationNodePropertyContainsRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkflowSpecificationNodePropertyContainsRelationship);
        }

        public bool Equals(WorkflowSpecificationNodePropertyContainsRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkflowSpecificationNodePropertyContainsRelationship? left, WorkflowSpecificationNodePropertyContainsRelationship? right)
        {
            return EqualityComparer<WorkflowSpecificationNodePropertyContainsRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkflowSpecificationNodePropertyContainsRelationship? left, WorkflowSpecificationNodePropertyContainsRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkflowSpecificationNodePropertyContainsRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}