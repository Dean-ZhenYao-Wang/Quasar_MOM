namespace MOM.Domain.Common.Relationship.isa95.WorkflowSpecification
{
    public class WorkflowSpecificationIncludesPropertiesOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecification>, IEquatable<WorkflowSpecificationIncludesPropertiesOfRelationship>
    {
        public WorkflowSpecificationIncludesPropertiesOfRelationship()
        {
            Name = "includesPropertiesOf";
        }

        public WorkflowSpecificationIncludesPropertiesOfRelationship(Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecification source, Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecification target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkflowSpecificationIncludesPropertiesOfRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkflowSpecificationIncludesPropertiesOfRelationship);
        }

        public bool Equals(WorkflowSpecificationIncludesPropertiesOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkflowSpecificationIncludesPropertiesOfRelationship? left, WorkflowSpecificationIncludesPropertiesOfRelationship? right)
        {
            return EqualityComparer<WorkflowSpecificationIncludesPropertiesOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkflowSpecificationIncludesPropertiesOfRelationship? left, WorkflowSpecificationIncludesPropertiesOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkflowSpecificationIncludesPropertiesOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}