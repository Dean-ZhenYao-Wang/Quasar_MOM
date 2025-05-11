namespace MOM.Domain.Common.Relationship.isa95.WorkflowSpecificationConnectionType
{
    public class WorkflowSpecificationConnectionTypeHasPropertiesOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationConnectionTypeProperty>, IEquatable<WorkflowSpecificationConnectionTypeHasPropertiesOfRelationship>
    {
        public WorkflowSpecificationConnectionTypeHasPropertiesOfRelationship()
        {
            Name = "hasPropertiesOf";
        }

        public WorkflowSpecificationConnectionTypeHasPropertiesOfRelationship(Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationConnectionType source, Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationConnectionTypeProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkflowSpecificationConnectionTypeHasPropertiesOfRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkflowSpecificationConnectionTypeHasPropertiesOfRelationship);
        }

        public bool Equals(WorkflowSpecificationConnectionTypeHasPropertiesOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkflowSpecificationConnectionTypeHasPropertiesOfRelationship? left, WorkflowSpecificationConnectionTypeHasPropertiesOfRelationship? right)
        {
            return EqualityComparer<WorkflowSpecificationConnectionTypeHasPropertiesOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkflowSpecificationConnectionTypeHasPropertiesOfRelationship? left, WorkflowSpecificationConnectionTypeHasPropertiesOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkflowSpecificationConnectionTypeHasPropertiesOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}