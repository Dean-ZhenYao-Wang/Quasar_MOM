namespace MOM.Domain.Common.Relationship.isa95.WorkflowSpecificationNodeType
{
    public class WorkflowSpecificationNodeTypeHasPropertiesOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationNodeTypeProperty>, IEquatable<WorkflowSpecificationNodeTypeHasPropertiesOfRelationship>
    {
        public WorkflowSpecificationNodeTypeHasPropertiesOfRelationship()
        {
            Name = "hasPropertiesOf";
        }

        public WorkflowSpecificationNodeTypeHasPropertiesOfRelationship(Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationNodeType source, Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationNodeTypeProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkflowSpecificationNodeTypeHasPropertiesOfRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkflowSpecificationNodeTypeHasPropertiesOfRelationship);
        }

        public bool Equals(WorkflowSpecificationNodeTypeHasPropertiesOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkflowSpecificationNodeTypeHasPropertiesOfRelationship? left, WorkflowSpecificationNodeTypeHasPropertiesOfRelationship? right)
        {
            return EqualityComparer<WorkflowSpecificationNodeTypeHasPropertiesOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkflowSpecificationNodeTypeHasPropertiesOfRelationship? left, WorkflowSpecificationNodeTypeHasPropertiesOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkflowSpecificationNodeTypeHasPropertiesOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}