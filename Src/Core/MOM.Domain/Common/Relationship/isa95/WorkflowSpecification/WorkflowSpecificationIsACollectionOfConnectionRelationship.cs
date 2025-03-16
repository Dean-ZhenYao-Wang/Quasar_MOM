namespace MOM.Domain.Common.Relationship.isa95.WorkflowSpecification
{
    public class WorkflowSpecificationIsACollectionOfConnectionRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationConnection>, IEquatable<WorkflowSpecificationIsACollectionOfConnectionRelationship>
    {
        public WorkflowSpecificationIsACollectionOfConnectionRelationship()
        {
            Name = "isACollectionOfConnection";
        }

        public WorkflowSpecificationIsACollectionOfConnectionRelationship(Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecification source, Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationConnection target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkflowSpecificationIsACollectionOfConnectionRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkflowSpecificationIsACollectionOfConnectionRelationship);
        }

        public bool Equals(WorkflowSpecificationIsACollectionOfConnectionRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkflowSpecificationIsACollectionOfConnectionRelationship? left, WorkflowSpecificationIsACollectionOfConnectionRelationship? right)
        {
            return EqualityComparer<WorkflowSpecificationIsACollectionOfConnectionRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkflowSpecificationIsACollectionOfConnectionRelationship? left, WorkflowSpecificationIsACollectionOfConnectionRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkflowSpecificationIsACollectionOfConnectionRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}