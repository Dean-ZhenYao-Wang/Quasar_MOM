namespace MOM.Domain.Common.Relationship.isa95.WorkflowSpecificationConnection
{
    public class WorkflowSpecificationConnectionHasPropertiesOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationConnectionProperty>, IEquatable<WorkflowSpecificationConnectionHasPropertiesOfRelationship>
    {
        public WorkflowSpecificationConnectionHasPropertiesOfRelationship()
        {
            Name = "hasPropertiesOf";
        }

        public WorkflowSpecificationConnectionHasPropertiesOfRelationship(Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationConnection source, Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationConnectionProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkflowSpecificationConnectionHasPropertiesOfRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkflowSpecificationConnectionHasPropertiesOfRelationship);
        }

        public bool Equals(WorkflowSpecificationConnectionHasPropertiesOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkflowSpecificationConnectionHasPropertiesOfRelationship? left, WorkflowSpecificationConnectionHasPropertiesOfRelationship? right)
        {
            return EqualityComparer<WorkflowSpecificationConnectionHasPropertiesOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkflowSpecificationConnectionHasPropertiesOfRelationship? left, WorkflowSpecificationConnectionHasPropertiesOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkflowSpecificationConnectionHasPropertiesOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}