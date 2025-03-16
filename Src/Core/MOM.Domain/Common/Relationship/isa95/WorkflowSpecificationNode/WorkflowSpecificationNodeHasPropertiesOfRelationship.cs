namespace MOM.Domain.Common.Relationship.isa95.WorkflowSpecificationNode
{
    public class WorkflowSpecificationNodeHasPropertiesOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationNodeProperty>, IEquatable<WorkflowSpecificationNodeHasPropertiesOfRelationship>
    {
        public WorkflowSpecificationNodeHasPropertiesOfRelationship()
        {
            Name = "hasPropertiesOf";
        }

        public WorkflowSpecificationNodeHasPropertiesOfRelationship(Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationNode source, Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationNodeProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkflowSpecificationNodeHasPropertiesOfRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkflowSpecificationNodeHasPropertiesOfRelationship);
        }

        public bool Equals(WorkflowSpecificationNodeHasPropertiesOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkflowSpecificationNodeHasPropertiesOfRelationship? left, WorkflowSpecificationNodeHasPropertiesOfRelationship? right)
        {
            return EqualityComparer<WorkflowSpecificationNodeHasPropertiesOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkflowSpecificationNodeHasPropertiesOfRelationship? left, WorkflowSpecificationNodeHasPropertiesOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkflowSpecificationNodeHasPropertiesOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}