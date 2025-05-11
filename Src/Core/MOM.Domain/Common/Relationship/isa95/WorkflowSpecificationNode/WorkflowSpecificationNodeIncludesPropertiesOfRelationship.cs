namespace MOM.Domain.Common.Relationship.isa95.WorkflowSpecificationNode
{
    public class WorkflowSpecificationNodeIncludesPropertiesOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationNode>, IEquatable<WorkflowSpecificationNodeIncludesPropertiesOfRelationship>
    {
        public WorkflowSpecificationNodeIncludesPropertiesOfRelationship()
        {
            Name = "includesPropertiesOf";
        }

        public WorkflowSpecificationNodeIncludesPropertiesOfRelationship(Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationNode source, Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationNode target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkflowSpecificationNodeIncludesPropertiesOfRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkflowSpecificationNodeIncludesPropertiesOfRelationship);
        }

        public bool Equals(WorkflowSpecificationNodeIncludesPropertiesOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkflowSpecificationNodeIncludesPropertiesOfRelationship? left, WorkflowSpecificationNodeIncludesPropertiesOfRelationship? right)
        {
            return EqualityComparer<WorkflowSpecificationNodeIncludesPropertiesOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkflowSpecificationNodeIncludesPropertiesOfRelationship? left, WorkflowSpecificationNodeIncludesPropertiesOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkflowSpecificationNodeIncludesPropertiesOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}