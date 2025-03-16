namespace MOM.Domain.Common.Relationship.isa95.WorkflowSpecificationConnection
{
    public class WorkflowSpecificationConnectionConnectsFromRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationNode>, IEquatable<WorkflowSpecificationConnectionConnectsFromRelationship>
    {
        public WorkflowSpecificationConnectionConnectsFromRelationship()
        {
            Name = "connectsFrom";
        }

        public WorkflowSpecificationConnectionConnectsFromRelationship(Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationConnection source, Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationNode target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkflowSpecificationConnectionConnectsFromRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkflowSpecificationConnectionConnectsFromRelationship);
        }

        public bool Equals(WorkflowSpecificationConnectionConnectsFromRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkflowSpecificationConnectionConnectsFromRelationship? left, WorkflowSpecificationConnectionConnectsFromRelationship? right)
        {
            return EqualityComparer<WorkflowSpecificationConnectionConnectsFromRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkflowSpecificationConnectionConnectsFromRelationship? left, WorkflowSpecificationConnectionConnectsFromRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkflowSpecificationConnectionConnectsFromRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}