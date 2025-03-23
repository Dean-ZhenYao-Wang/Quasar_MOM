namespace MOM.Domain.Common.Relationship.isa95.WorkflowSpecificationConnection
{
    public class WorkflowSpecificationConnectionConnectsToRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationNode>, IEquatable<WorkflowSpecificationConnectionConnectsToRelationship>
    {
        public WorkflowSpecificationConnectionConnectsToRelationship()
        {
            Name = "connectsTo";
        }

        public WorkflowSpecificationConnectionConnectsToRelationship(Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationConnection source, Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationNode target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkflowSpecificationConnectionConnectsToRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkflowSpecificationConnectionConnectsToRelationship);
        }

        public bool Equals(WorkflowSpecificationConnectionConnectsToRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkflowSpecificationConnectionConnectsToRelationship? left, WorkflowSpecificationConnectionConnectsToRelationship? right)
        {
            return EqualityComparer<WorkflowSpecificationConnectionConnectsToRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkflowSpecificationConnectionConnectsToRelationship? left, WorkflowSpecificationConnectionConnectsToRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkflowSpecificationConnectionConnectsToRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}