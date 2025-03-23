namespace MOM.Domain.Common.Relationship.isa95.WorkflowSpecificationConnectionTypeProperty
{
    public class WorkflowSpecificationConnectionTypePropertyContainsRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationNodeTypeProperty>, IEquatable<WorkflowSpecificationConnectionTypePropertyContainsRelationship>
    {
        public WorkflowSpecificationConnectionTypePropertyContainsRelationship()
        {
            Name = "contains";
        }

        public WorkflowSpecificationConnectionTypePropertyContainsRelationship(Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationConnectionTypeProperty source, Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationNodeTypeProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkflowSpecificationConnectionTypePropertyContainsRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkflowSpecificationConnectionTypePropertyContainsRelationship);
        }

        public bool Equals(WorkflowSpecificationConnectionTypePropertyContainsRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkflowSpecificationConnectionTypePropertyContainsRelationship? left, WorkflowSpecificationConnectionTypePropertyContainsRelationship? right)
        {
            return EqualityComparer<WorkflowSpecificationConnectionTypePropertyContainsRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkflowSpecificationConnectionTypePropertyContainsRelationship? left, WorkflowSpecificationConnectionTypePropertyContainsRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkflowSpecificationConnectionTypePropertyContainsRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}