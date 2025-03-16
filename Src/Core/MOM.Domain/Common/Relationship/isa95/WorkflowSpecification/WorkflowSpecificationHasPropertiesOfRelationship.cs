namespace MOM.Domain.Common.Relationship.isa95.WorkflowSpecification
{
    public class WorkflowSpecificationHasPropertiesOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationProperty>, IEquatable<WorkflowSpecificationHasPropertiesOfRelationship>
    {
        public WorkflowSpecificationHasPropertiesOfRelationship()
        {
            Name = "hasPropertiesOf";
        }

        public WorkflowSpecificationHasPropertiesOfRelationship(Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecification source, Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkflowSpecificationHasPropertiesOfRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkflowSpecificationHasPropertiesOfRelationship);
        }

        public bool Equals(WorkflowSpecificationHasPropertiesOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkflowSpecificationHasPropertiesOfRelationship? left, WorkflowSpecificationHasPropertiesOfRelationship? right)
        {
            return EqualityComparer<WorkflowSpecificationHasPropertiesOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkflowSpecificationHasPropertiesOfRelationship? left, WorkflowSpecificationHasPropertiesOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkflowSpecificationHasPropertiesOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}