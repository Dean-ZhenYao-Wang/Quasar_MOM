namespace MOM.Domain.Common.Relationship.isa95.WorkflowSpecification
{
    public class WorkflowSpecificationIsACollectionOfNodeRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationNode>, IEquatable<WorkflowSpecificationIsACollectionOfNodeRelationship>
    {
        public WorkflowSpecificationIsACollectionOfNodeRelationship()
        {
            Name = "isACollectionOfNode";
        }

        public WorkflowSpecificationIsACollectionOfNodeRelationship(Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecification source, Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationNode target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkflowSpecificationIsACollectionOfNodeRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkflowSpecificationIsACollectionOfNodeRelationship);
        }

        public bool Equals(WorkflowSpecificationIsACollectionOfNodeRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkflowSpecificationIsACollectionOfNodeRelationship? left, WorkflowSpecificationIsACollectionOfNodeRelationship? right)
        {
            return EqualityComparer<WorkflowSpecificationIsACollectionOfNodeRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkflowSpecificationIsACollectionOfNodeRelationship? left, WorkflowSpecificationIsACollectionOfNodeRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkflowSpecificationIsACollectionOfNodeRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}